namespace Technoservice
{
    partial class EmployeeForm
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
            this.troublesData = new System.Windows.Forms.DataGridView();
            this.troubleViewBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.terna_Techoservice1DataSet11 = new Technoservice.Terna_Techoservice1DataSet11();
            this.troubleViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.terna_Techoservice1DataSet1 = new Technoservice.Terna_Techoservice1DataSet1();
            this.troubleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terna_Techoservice1DataSet = new Technoservice.Terna_Techoservice1DataSet();
            this.troubleViewTableAdapter = new Technoservice.Terna_Techoservice1DataSetTableAdapters.TroubleViewTableAdapter();
            this.discriptBox = new System.Windows.Forms.RichTextBox();
            this.discriptionGroup = new System.Windows.Forms.GroupBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.troubleViewTableAdapter1 = new Technoservice.Terna_Techoservice1DataSet1TableAdapters.TroubleViewTableAdapter();
            this.terna_Techoservice1DataSet8 = new Technoservice.Terna_Techoservice1DataSet8();
            this.troubleViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.troubleViewTableAdapter2 = new Technoservice.Terna_Techoservice1DataSet8TableAdapters.TroubleViewTableAdapter();
            this.terna_Techoservice1DataSet9 = new Technoservice.Terna_Techoservice1DataSet9();
            this.troubleViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.troubleViewTableAdapter3 = new Technoservice.Terna_Techoservice1DataSet9TableAdapters.TroubleViewTableAdapter();
            this.trouble_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terna_Techoservice1DataSet10 = new Technoservice.Terna_Techoservice1DataSet10();
            this.troubleViewBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.troubleViewTableAdapter4 = new Technoservice.Terna_Techoservice1DataSet10TableAdapters.TroubleViewTableAdapter();
            this.troubleViewTableAdapter5 = new Technoservice.Terna_Techoservice1DataSet11TableAdapters.TroubleViewTableAdapter();
            this.troubleViewBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.номерЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типНеисправностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ответственныйDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыполнениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.troublesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet)).BeginInit();
            this.discriptionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // troublesData
            // 
            this.troublesData.AllowUserToAddRows = false;
            this.troublesData.AllowUserToDeleteRows = false;
            this.troublesData.AutoGenerateColumns = false;
            this.troublesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.troublesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЗаказаDataGridViewTextBoxColumn,
            this.типНеисправностиDataGridViewTextBoxColumn,
            this.заказчикDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.ответственныйDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.датаВыполнениеDataGridViewTextBoxColumn});
            this.troublesData.DataSource = this.troubleViewBindingSource6;
            this.troublesData.Location = new System.Drawing.Point(12, 5);
            this.troublesData.Name = "troublesData";
            this.troublesData.ReadOnly = true;
            this.troublesData.Size = new System.Drawing.Size(645, 308);
            this.troublesData.TabIndex = 0;
            this.troublesData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.troublesData_CellClick);
            // 
            // troubleViewBindingSource5
            // 
            this.troubleViewBindingSource5.DataMember = "TroubleView";
            this.troubleViewBindingSource5.DataSource = this.terna_Techoservice1DataSet11;
            // 
            // terna_Techoservice1DataSet11
            // 
            this.terna_Techoservice1DataSet11.DataSetName = "Terna_Techoservice1DataSet11";
            this.terna_Techoservice1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // troubleViewBindingSource1
            // 
            this.troubleViewBindingSource1.DataMember = "TroubleView";
            this.troubleViewBindingSource1.DataSource = this.terna_Techoservice1DataSet1;
            // 
            // terna_Techoservice1DataSet1
            // 
            this.terna_Techoservice1DataSet1.DataSetName = "Terna_Techoservice1DataSet1";
            this.terna_Techoservice1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // troubleViewBindingSource
            // 
            this.troubleViewBindingSource.DataMember = "TroubleView";
            this.troubleViewBindingSource.DataSource = this.terna_Techoservice1DataSet;
            // 
            // terna_Techoservice1DataSet
            // 
            this.terna_Techoservice1DataSet.DataSetName = "Terna_Techoservice1DataSet";
            this.terna_Techoservice1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // troubleViewTableAdapter
            // 
            this.troubleViewTableAdapter.ClearBeforeFill = true;
            // 
            // discriptBox
            // 
            this.discriptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discriptBox.Location = new System.Drawing.Point(6, 19);
            this.discriptBox.Name = "discriptBox";
            this.discriptBox.Size = new System.Drawing.Size(300, 156);
            this.discriptBox.TabIndex = 1;
            this.discriptBox.Text = "";
            // 
            // discriptionGroup
            // 
            this.discriptionGroup.Controls.Add(this.discriptBox);
            this.discriptionGroup.Location = new System.Drawing.Point(663, 131);
            this.discriptionGroup.Name = "discriptionGroup";
            this.discriptionGroup.Size = new System.Drawing.Size(312, 182);
            this.discriptionGroup.TabIndex = 2;
            this.discriptionGroup.TabStop = false;
            this.discriptionGroup.Text = "Описание:";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(12, 498);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 34);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.Location = new System.Drawing.Point(807, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(156, 20);
            this.logoLabel.TabIndex = 13;
            this.logoLabel.Text = "ООО \"Техносервис\"";
            // 
            // troubleViewTableAdapter1
            // 
            this.troubleViewTableAdapter1.ClearBeforeFill = true;
            // 
            // terna_Techoservice1DataSet8
            // 
            this.terna_Techoservice1DataSet8.DataSetName = "Terna_Techoservice1DataSet8";
            this.terna_Techoservice1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // troubleViewBindingSource2
            // 
            this.troubleViewBindingSource2.DataMember = "TroubleView";
            this.troubleViewBindingSource2.DataSource = this.terna_Techoservice1DataSet8;
            // 
            // troubleViewTableAdapter2
            // 
            this.troubleViewTableAdapter2.ClearBeforeFill = true;
            // 
            // terna_Techoservice1DataSet9
            // 
            this.terna_Techoservice1DataSet9.DataSetName = "Terna_Techoservice1DataSet9";
            this.terna_Techoservice1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // troubleViewBindingSource3
            // 
            this.troubleViewBindingSource3.DataMember = "TroubleView";
            this.troubleViewBindingSource3.DataSource = this.terna_Techoservice1DataSet9;
            // 
            // troubleViewTableAdapter3
            // 
            this.troubleViewTableAdapter3.ClearBeforeFill = true;
            // 
            // trouble_id
            // 
            this.trouble_id.DataPropertyName = "trouble_id";
            this.trouble_id.HeaderText = "trouble_id";
            this.trouble_id.Name = "trouble_id";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "trouble_discription";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // terna_Techoservice1DataSet10
            // 
            this.terna_Techoservice1DataSet10.DataSetName = "Terna_Techoservice1DataSet10";
            this.terna_Techoservice1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // troubleViewBindingSource4
            // 
            this.troubleViewBindingSource4.DataMember = "TroubleView";
            this.troubleViewBindingSource4.DataSource = this.terna_Techoservice1DataSet10;
            // 
            // troubleViewTableAdapter4
            // 
            this.troubleViewTableAdapter4.ClearBeforeFill = true;
            // 
            // troubleViewTableAdapter5
            // 
            this.troubleViewTableAdapter5.ClearBeforeFill = true;
            // 
            // troubleViewBindingSource6
            // 
            this.troubleViewBindingSource6.DataMember = "TroubleView";
            this.troubleViewBindingSource6.DataSource = this.terna_Techoservice1DataSet10;
            // 
            // номерЗаказаDataGridViewTextBoxColumn
            // 
            this.номерЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.Name = "номерЗаказаDataGridViewTextBoxColumn";
            this.номерЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типНеисправностиDataGridViewTextBoxColumn
            // 
            this.типНеисправностиDataGridViewTextBoxColumn.DataPropertyName = "Тип неисправности";
            this.типНеисправностиDataGridViewTextBoxColumn.HeaderText = "Тип неисправности";
            this.типНеисправностиDataGridViewTextBoxColumn.Name = "типНеисправностиDataGridViewTextBoxColumn";
            this.типНеисправностиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // заказчикDataGridViewTextBoxColumn
            // 
            this.заказчикDataGridViewTextBoxColumn.DataPropertyName = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.Name = "заказчикDataGridViewTextBoxColumn";
            this.заказчикDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ответственныйDataGridViewTextBoxColumn
            // 
            this.ответственныйDataGridViewTextBoxColumn.DataPropertyName = "Ответственный";
            this.ответственныйDataGridViewTextBoxColumn.HeaderText = "Ответственный";
            this.ответственныйDataGridViewTextBoxColumn.Name = "ответственныйDataGridViewTextBoxColumn";
            this.ответственныйDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            this.датаЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаВыполнениеDataGridViewTextBoxColumn
            // 
            this.датаВыполнениеDataGridViewTextBoxColumn.DataPropertyName = "Дата выполнение";
            this.датаВыполнениеDataGridViewTextBoxColumn.HeaderText = "Дата выполнение";
            this.датаВыполнениеDataGridViewTextBoxColumn.Name = "датаВыполнениеDataGridViewTextBoxColumn";
            this.датаВыполнениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 544);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.discriptionGroup);
            this.Controls.Add(this.troublesData);
            this.Name = "EmployeeForm";
            this.Text = "\"ООО\" Техносервис";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.troublesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet)).EndInit();
            this.discriptionGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleViewBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView troublesData;
        private Terna_Techoservice1DataSet terna_Techoservice1DataSet;
        private System.Windows.Forms.BindingSource troubleViewBindingSource;
        private Terna_Techoservice1DataSetTableAdapters.TroubleViewTableAdapter troubleViewTableAdapter;
        private System.Windows.Forms.RichTextBox discriptBox;
        private System.Windows.Forms.GroupBox discriptionGroup;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label logoLabel;
        private Terna_Techoservice1DataSet1 terna_Techoservice1DataSet1;
        private System.Windows.Forms.BindingSource troubleViewBindingSource1;
        private Terna_Techoservice1DataSet1TableAdapters.TroubleViewTableAdapter troubleViewTableAdapter1;
        private Terna_Techoservice1DataSet8 terna_Techoservice1DataSet8;
        private System.Windows.Forms.BindingSource troubleViewBindingSource2;
        private Terna_Techoservice1DataSet8TableAdapters.TroubleViewTableAdapter troubleViewTableAdapter2;
        private Terna_Techoservice1DataSet9 terna_Techoservice1DataSet9;
        private System.Windows.Forms.BindingSource troubleViewBindingSource3;
        private Terna_Techoservice1DataSet9TableAdapters.TroubleViewTableAdapter troubleViewTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn trouble_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Terna_Techoservice1DataSet10 terna_Techoservice1DataSet10;
        private System.Windows.Forms.BindingSource troubleViewBindingSource4;
        private Terna_Techoservice1DataSet10TableAdapters.TroubleViewTableAdapter troubleViewTableAdapter4;
        private Terna_Techoservice1DataSet11 terna_Techoservice1DataSet11;
        private System.Windows.Forms.BindingSource troubleViewBindingSource5;
        private Terna_Techoservice1DataSet11TableAdapters.TroubleViewTableAdapter troubleViewTableAdapter5;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типНеисправностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ответственныйDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыполнениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource troubleViewBindingSource6;
    }
}