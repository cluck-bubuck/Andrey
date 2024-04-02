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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Technoservice
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            logForm logForm = new logForm();
            logForm.Show();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "terna_Techoservice1DataSet7.Worker_Manager_View". При необходимости она может быть перемещена или удалена.
            this.worker_Manager_ViewTableAdapter.Fill(this.terna_Techoservice1DataSet7.Worker_Manager_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "terna_Techoservice1DataSet5.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.terna_Techoservice1DataSet5.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "terna_Techoservice1DataSet4.Trouble". При необходимости она может быть перемещена или удалена.
            this.troubleTableAdapter.Fill(this.terna_Techoservice1DataSet4.Trouble);

        }

        private void filterBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }
    }
}
