using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace Technoservice
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "terna_Techoservice1DataSet12.Trouble". При необходимости она может быть перемещена или удалена.
            this.troubleTableAdapter.Fill(this.terna_Techoservice1DataSet12.Trouble);
        }

        private void CreateRepBtn_Click(object sender, EventArgs e)
        {
            //Узнаем путь к рабочему столу
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            //Коннект к БД
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = UserClass.enterLink;

            try
            {
                connect.Open();
                SqlCommand reportCreate = new SqlCommand();
                reportCreate.CommandType = CommandType.StoredProcedure;
                reportCreate.CommandText = "ReportProc";
                reportCreate.Connection = connect;
                SqlDataReader sqlReader = reportCreate.ExecuteReader();
                sqlReader.Read();

                //подтягиваем лицензию
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                //создаём объект документа 
                ExcelPackage reportExcel = new ExcelPackage();

                //добавляем страничку 
                ExcelWorksheet excelWorkSheet = reportExcel.Workbook.Worksheets.Add("FileFormat");
                excelWorkSheet.Cells["A1"].Value = sqlReader.GetInt32(0);
                excelWorkSheet.Cells["B1"].Value = sqlReader.GetString(1);
                excelWorkSheet.Cells["C1"].Value = sqlReader.GetString(2);
                excelWorkSheet.Cells["D1"].Value = sqlReader.GetString(3);
                excelWorkSheet.Cells["E1"].Value = sqlReader.GetInt32(4);


                //выделение заголовка
                excelWorkSheet.Cells["A1:G1"].Style.Border.BorderAround(ExcelBorderStyle.Thick);
                excelWorkSheet.Cells["A1:G1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                //курсивный шрифт
                excelWorkSheet.Cells["A5:B10"].Style.Font.Italic = true;

                //ставим сегодняшнюю дату
                excelWorkSheet.Cells["G13"].Value = DateTime.Today;

                //дата
                excelWorkSheet.Cells["G13"].Style.Numberformat.Format = "yyyy-mm-dd";
                excelWorkSheet.Cells["G13"].AutoFitColumns();

                connect.Close();
                connect.Open();

                //После открытия соединения используя Select выбираем имя и фамилию из таблички в БД
                using (SqlCommand sqlCom = new SqlCommand(@"Select user_name +' '+ user_surname From [User] where user_login like @user_id", connect))
                {
                    SqlParameter user_id = new SqlParameter("@user_id", UserClass.user_id);
                    sqlCom.Parameters.Add(user_id);
                    sqlReader = sqlCom.ExecuteReader();
                    sqlReader.Read();

                    excelWorkSheet.Cells["B13"].Value = sqlReader.GetString(0);

                    //место для подписи
                    excelWorkSheet.Cells["E13"].Style.Border.Bottom.Style = ExcelBorderStyle.Thick;

                    //создание файла
                    reportExcel.SaveAs(new FileInfo($"{desktopPath}\\ОТЧЕТ {DateTime.Today}.xlsx"));

                    MessageBox.Show("Отчет успешно создан на рабочем столе!");
                }
            }

            catch (Exception ex) { MessageBox.Show($"Ошибка, ({ex.Message})"); }
        }
    }
}
