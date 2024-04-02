namespace Technoservice
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TroubleData = new System.Windows.Forms.DataGridView();
            this.troubleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troublediscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troublestatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troublestartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troubleenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troubleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terna_Techoservice1DataSet4 = new Technoservice.Terna_Techoservice1DataSet4();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.workerManagerViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terna_Techoservice1DataSet7 = new Technoservice.Terna_Techoservice1DataSet7();
            this.button1 = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportBtn = new System.Windows.Forms.Button();
            this.OrderData = new System.Windows.Forms.DataGridView();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordernumbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troubleidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderadddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderpriorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terna_Techoservice1DataSet5 = new Technoservice.Terna_Techoservice1DataSet5();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.troubleTableAdapter = new Technoservice.Terna_Techoservice1DataSet4TableAdapters.TroubleTableAdapter();
            this.orderTableAdapter = new Technoservice.Terna_Techoservice1DataSet5TableAdapters.OrderTableAdapter();
            this.worker_Manager_ViewTableAdapter = new Technoservice.Terna_Techoservice1DataSet7TableAdapters.Worker_Manager_ViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TroubleData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerManagerViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet7)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TroubleData
            // 
            this.TroubleData.AutoGenerateColumns = false;
            this.TroubleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TroubleData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.troubleidDataGridViewTextBoxColumn,
            this.troublediscriptionDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.typeidDataGridViewTextBoxColumn,
            this.workeridDataGridViewTextBoxColumn,
            this.troublestatusDataGridViewTextBoxColumn,
            this.troublestartdateDataGridViewTextBoxColumn,
            this.troubleenddateDataGridViewTextBoxColumn});
            this.TroubleData.DataSource = this.troubleBindingSource;
            this.TroubleData.Location = new System.Drawing.Point(6, 19);
            this.TroubleData.Name = "TroubleData";
            this.TroubleData.Size = new System.Drawing.Size(497, 364);
            this.TroubleData.TabIndex = 0;
            // 
            // troubleidDataGridViewTextBoxColumn
            // 
            this.troubleidDataGridViewTextBoxColumn.DataPropertyName = "trouble_id";
            this.troubleidDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.troubleidDataGridViewTextBoxColumn.Name = "troubleidDataGridViewTextBoxColumn";
            this.troubleidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // troublediscriptionDataGridViewTextBoxColumn
            // 
            this.troublediscriptionDataGridViewTextBoxColumn.DataPropertyName = "trouble_discription";
            this.troublediscriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.troublediscriptionDataGridViewTextBoxColumn.Name = "troublediscriptionDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeidDataGridViewTextBoxColumn
            // 
            this.typeidDataGridViewTextBoxColumn.DataPropertyName = "type_id";
            this.typeidDataGridViewTextBoxColumn.HeaderText = "Тип неисправности";
            this.typeidDataGridViewTextBoxColumn.Name = "typeidDataGridViewTextBoxColumn";
            // 
            // workeridDataGridViewTextBoxColumn
            // 
            this.workeridDataGridViewTextBoxColumn.DataPropertyName = "worker_id";
            this.workeridDataGridViewTextBoxColumn.HeaderText = "Ответственный";
            this.workeridDataGridViewTextBoxColumn.Name = "workeridDataGridViewTextBoxColumn";
            // 
            // troublestatusDataGridViewTextBoxColumn
            // 
            this.troublestatusDataGridViewTextBoxColumn.DataPropertyName = "trouble_status";
            this.troublestatusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.troublestatusDataGridViewTextBoxColumn.Name = "troublestatusDataGridViewTextBoxColumn";
            // 
            // troublestartdateDataGridViewTextBoxColumn
            // 
            this.troublestartdateDataGridViewTextBoxColumn.DataPropertyName = "trouble_startdate";
            this.troublestartdateDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.troublestartdateDataGridViewTextBoxColumn.Name = "troublestartdateDataGridViewTextBoxColumn";
            // 
            // troubleenddateDataGridViewTextBoxColumn
            // 
            this.troubleenddateDataGridViewTextBoxColumn.DataPropertyName = "trouble_enddate";
            this.troubleenddateDataGridViewTextBoxColumn.HeaderText = "Дата выполнения";
            this.troubleenddateDataGridViewTextBoxColumn.Name = "troubleenddateDataGridViewTextBoxColumn";
            // 
            // troubleBindingSource
            // 
            this.troubleBindingSource.DataMember = "Trouble";
            this.troubleBindingSource.DataSource = this.terna_Techoservice1DataSet4;
            // 
            // terna_Techoservice1DataSet4
            // 
            this.terna_Techoservice1DataSet4.DataSetName = "Terna_Techoservice1DataSet4";
            this.terna_Techoservice1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.priorityBox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.logoLabel);
            this.panel1.Controls.Add(this.filterBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 159);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(500, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Изменить приоритет";
            // 
            // priorityBox
            // 
            this.priorityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.priorityBox.Location = new System.Drawing.Point(675, 96);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(121, 28);
            this.priorityBox.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.workerManagerViewBindingSource, "worker_id", true));
            this.comboBox1.DataSource = this.workerManagerViewBindingSource;
            this.comboBox1.DisplayMember = "ФИО работника";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "worker_id";
            // 
            // workerManagerViewBindingSource
            // 
            this.workerManagerViewBindingSource.DataMember = "Worker_Manager_View";
            this.workerManagerViewBindingSource.DataSource = this.terna_Techoservice1DataSet7;
            // 
            // terna_Techoservice1DataSet7
            // 
            this.terna_Techoservice1DataSet7.DataSetName = "Terna_Techoservice1DataSet7";
            this.terna_Techoservice1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить ответсвенного";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.Location = new System.Drawing.Point(860, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(156, 20);
            this.logoLabel.TabIndex = 13;
            this.logoLabel.Text = "ООО \"Техносервис\"";
            // 
            // filterBox
            // 
            this.filterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterBox.Location = new System.Drawing.Point(675, 130);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(139, 26);
            this.filterBox.TabIndex = 2;
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(515, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск по артикулю";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 28);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportBtn);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 34);
            this.panel2.TabIndex = 2;
            // 
            // reportBtn
            // 
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportBtn.Location = new System.Drawing.Point(473, 3);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(75, 27);
            this.reportBtn.TabIndex = 1;
            this.reportBtn.Text = "Отчёт";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // OrderData
            // 
            this.OrderData.AutoGenerateColumns = false;
            this.OrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.ordernumbDataGridViewTextBoxColumn,
            this.orderstatusDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.troubleidDataGridViewTextBoxColumn1,
            this.orderadddateDataGridViewTextBoxColumn,
            this.orderenddateDataGridViewTextBoxColumn,
            this.orderpriorityDataGridViewTextBoxColumn});
            this.OrderData.DataSource = this.orderBindingSource;
            this.OrderData.Location = new System.Drawing.Point(5, 19);
            this.OrderData.Name = "OrderData";
            this.OrderData.Size = new System.Drawing.Size(497, 364);
            this.OrderData.TabIndex = 3;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordernumbDataGridViewTextBoxColumn
            // 
            this.ordernumbDataGridViewTextBoxColumn.DataPropertyName = "order_numb";
            this.ordernumbDataGridViewTextBoxColumn.HeaderText = "Артикуль";
            this.ordernumbDataGridViewTextBoxColumn.Name = "ordernumbDataGridViewTextBoxColumn";
            // 
            // orderstatusDataGridViewTextBoxColumn
            // 
            this.orderstatusDataGridViewTextBoxColumn.DataPropertyName = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.orderstatusDataGridViewTextBoxColumn.Name = "orderstatusDataGridViewTextBoxColumn";
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            // 
            // troubleidDataGridViewTextBoxColumn1
            // 
            this.troubleidDataGridViewTextBoxColumn1.DataPropertyName = "trouble_id";
            this.troubleidDataGridViewTextBoxColumn1.HeaderText = "Номер заявки";
            this.troubleidDataGridViewTextBoxColumn1.Name = "troubleidDataGridViewTextBoxColumn1";
            // 
            // orderadddateDataGridViewTextBoxColumn
            // 
            this.orderadddateDataGridViewTextBoxColumn.DataPropertyName = "order_add_date";
            this.orderadddateDataGridViewTextBoxColumn.HeaderText = "Дата добавления";
            this.orderadddateDataGridViewTextBoxColumn.Name = "orderadddateDataGridViewTextBoxColumn";
            // 
            // orderenddateDataGridViewTextBoxColumn
            // 
            this.orderenddateDataGridViewTextBoxColumn.DataPropertyName = "order_end_date";
            this.orderenddateDataGridViewTextBoxColumn.HeaderText = "Дата выполнения";
            this.orderenddateDataGridViewTextBoxColumn.Name = "orderenddateDataGridViewTextBoxColumn";
            // 
            // orderpriorityDataGridViewTextBoxColumn
            // 
            this.orderpriorityDataGridViewTextBoxColumn.DataPropertyName = "order_priority";
            this.orderpriorityDataGridViewTextBoxColumn.HeaderText = "Приоритет";
            this.orderpriorityDataGridViewTextBoxColumn.Name = "orderpriorityDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.terna_Techoservice1DataSet5;
            // 
            // terna_Techoservice1DataSet5
            // 
            this.terna_Techoservice1DataSet5.DataSetName = "Terna_Techoservice1DataSet5";
            this.terna_Techoservice1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TroubleData);
            this.groupBox1.Location = new System.Drawing.Point(2, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 388);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заявки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OrderData);
            this.groupBox2.Location = new System.Drawing.Point(511, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 388);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заказы";
            // 
            // troubleTableAdapter
            // 
            this.troubleTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // worker_Manager_ViewTableAdapter
            // 
            this.worker_Manager_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerForm";
            this.Text = "\"ООО\" Техносервис";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TroubleData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerManagerViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet7)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TroubleData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView OrderData;
        private System.Windows.Forms.GroupBox groupBox2;
        private Terna_Techoservice1DataSet4 terna_Techoservice1DataSet4;
        private System.Windows.Forms.BindingSource troubleBindingSource;
        private Terna_Techoservice1DataSet4TableAdapters.TroubleTableAdapter troubleTableAdapter;
        private Terna_Techoservice1DataSet5 terna_Techoservice1DataSet5;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private Terna_Techoservice1DataSet5TableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn troubleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troublediscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troublestatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troublestartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troubleenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troubleidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderadddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderpriorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private Terna_Techoservice1DataSet7 terna_Techoservice1DataSet7;
        private System.Windows.Forms.BindingSource workerManagerViewBindingSource;
        private Terna_Techoservice1DataSet7TableAdapters.Worker_Manager_ViewTableAdapter worker_Manager_ViewTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.Button reportBtn;
    }
}