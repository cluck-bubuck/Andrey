using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Technoservice
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(UserClass.enterLink);

        //Вывод заявок назначенных только вошедшему мастеру
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "terna_Techoservice1DataSet11.TroubleView". При необходимости она может быть перемещена или удалена.
            this.troubleViewTableAdapter5.Fill(this.terna_Techoservice1DataSet11.TroubleView);

            connect.Open();
            using (SqlCommand sqlCom = new SqlCommand($@"Select w.worker_id as 'CoolWorker'from Worker w join [User] u on w.[user_id] = @user_id", connect))
            {
                SqlParameter workerPar = new SqlParameter("@user_id", UserClass.user_id);
                sqlCom.Parameters.Add(workerPar);
                SqlDataReader sqlReader = sqlCom.ExecuteReader();
                sqlReader.Read();
            }
        }

        //Вывод описания заявки в рич боксе при нажатии на клетку в датагриде
        private void troublesData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Вывод описание в richTextBox при нажатии на клетку в dataGridView
            if (e.RowIndex != null & e.RowIndex != -1)
            {
                connect.Close();
                connect.Open();
                SqlCommand sqlDiscriptCom = new SqlCommand($@"Select trouble_discription from Trouble where trouble_id = {Convert.ToInt32(troublesData.Rows[e.RowIndex].Cells[0].Value)}", connect);
                SqlDataReader sqlReader = sqlDiscriptCom.ExecuteReader();
                sqlReader.Read();
                discriptBox.Text = sqlReader.GetString(0);
            }
        }

        //Кнопка перемещения на предыдущую форму
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            logForm logForm = new logForm();
            logForm.Show();
        }
    }
}
