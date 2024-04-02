using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Technoservice
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            logForm form1 = new logForm();
            form1.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int user_id;
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = UserClass.enterLink;

            //Поиск id пользователя по введенному им ФИО
            connect.Open();
            using (SqlCommand sqlCom = new SqlCommand($@"Select user_id From [User] where user_name like @name and user_surname like @surname", connect))
            {
                SqlParameter namePar = new SqlParameter("@name", nameTxt.Text);
                SqlParameter surnamePar = new SqlParameter("@surname", surnameTxt.Text);
                sqlCom.Parameters.Add(namePar);
                sqlCom.Parameters.Add(surnamePar);
                SqlDataReader sqlReader = sqlCom.ExecuteReader();
                sqlReader.Read();
                user_id = sqlReader.GetInt32(0);
            }

            //выполнение процедуры добавления заявки в БД
            try
            {
                connect.Close();
                connect.Open();
                SqlCommand enter = new SqlCommand();
                enter.CommandType = CommandType.StoredProcedure;
                enter.CommandText = "Add_Trouble";
                enter.Parameters.AddWithValue("@tr_discription", discriptionBox.Text);
                enter.Parameters.AddWithValue("@type_id", typeComBx.SelectedIndex + 1);
                enter.Parameters.AddWithValue("@user_id", user_id);
                enter.Connection = connect;
                SqlDataReader sqlReader = enter.ExecuteReader();
                sqlReader.Read();
                connect.Close();
                MessageBox.Show("Заявка успешно добавлена!");
            }

            //Сообщение об ошибках
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка, ({ex.Message})");
            }
        }
        
        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "terna_Techoservice1DataSet3.TroubleType". При необходимости она может быть перемещена или удалена.
            this.troubleTypeTableAdapter1.Fill(this.terna_Techoservice1DataSet3.TroubleType);
            typeComBx.SelectedIndex = 1;

        }

        //Открытие формы с qr кодом
        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            QrForm qrForm = new QrForm();
            qrForm.Show();
        }
    }
}
