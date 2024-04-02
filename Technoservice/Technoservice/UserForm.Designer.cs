namespace Technoservice
{
    partial class UserForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.typeComBx = new System.Windows.Forms.ComboBox();
            this.troubleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terna_TechoserviceDataSet = new Technoservice.Terna_TechoserviceDataSet();
            this.troubleTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.terna_Techoservice1DataSet3 = new Technoservice.Terna_Techoservice1DataSet3();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.troubleTypeTableAdapter = new Technoservice.Terna_TechoserviceDataSetTableAdapters.TroubleTypeTableAdapter();
            this.discriptionBox = new System.Windows.Forms.RichTextBox();
            this.troubleTypeTableAdapter1 = new Technoservice.Terna_Techoservice1DataSet3TableAdapters.TroubleTypeTableAdapter();
            this.feedbackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.troubleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_TechoserviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(2, 414);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 33);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(210, 414);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 33);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(331, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Описание проблемы";
            // 
            // typeComBx
            // 
            this.typeComBx.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.troubleTypeBindingSource, "type_id", true));
            this.typeComBx.DataSource = this.troubleTypeBindingSource1;
            this.typeComBx.DisplayMember = "type_name";
            this.typeComBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComBx.FormattingEnabled = true;
            this.typeComBx.Location = new System.Drawing.Point(133, 153);
            this.typeComBx.Name = "typeComBx";
            this.typeComBx.Size = new System.Drawing.Size(139, 28);
            this.typeComBx.TabIndex = 3;
            this.typeComBx.ValueMember = "type_id";
            // 
            // troubleTypeBindingSource
            // 
            this.troubleTypeBindingSource.DataMember = "TroubleType";
            this.troubleTypeBindingSource.DataSource = this.terna_TechoserviceDataSet;
            // 
            // terna_TechoserviceDataSet
            // 
            this.terna_TechoserviceDataSet.DataSetName = "Terna_TechoserviceDataSet";
            this.terna_TechoserviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // troubleTypeBindingSource1
            // 
            this.troubleTypeBindingSource1.DataMember = "TroubleType";
            this.troubleTypeBindingSource1.DataSource = this.terna_Techoservice1DataSet3;
            // 
            // terna_Techoservice1DataSet3
            // 
            this.terna_Techoservice1DataSet3.DataSetName = "Terna_Techoservice1DataSet3";
            this.terna_Techoservice1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTxt.Location = new System.Drawing.Point(133, 219);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(139, 26);
            this.surnameTxt.TabIndex = 7;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTxt.Location = new System.Drawing.Point(133, 187);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(139, 26);
            this.nameTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Тип проблемы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ваше имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ваша фамилия";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.Location = new System.Drawing.Point(177, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(156, 20);
            this.logoLabel.TabIndex = 12;
            this.logoLabel.Text = "ООО \"Техносервис\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(175, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Заполнение заявки";
            // 
            // troubleTypeTableAdapter
            // 
            this.troubleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // discriptionBox
            // 
            this.discriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discriptionBox.Location = new System.Drawing.Point(278, 153);
            this.discriptionBox.Name = "discriptionBox";
            this.discriptionBox.Size = new System.Drawing.Size(260, 92);
            this.discriptionBox.TabIndex = 14;
            this.discriptionBox.Text = "";
            // 
            // troubleTypeTableAdapter1
            // 
            this.troubleTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feedbackBtn.Location = new System.Drawing.Point(394, 417);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(144, 30);
            this.feedbackBtn.TabIndex = 15;
            this.feedbackBtn.Text = "Обратная связь";
            this.feedbackBtn.UseVisualStyleBackColor = true;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.feedbackBtn);
            this.Controls.Add(this.discriptionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.typeComBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.Text = "Добавление заявки";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.troubleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_TechoserviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troubleTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeComBx;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label label2;
        private Terna_TechoserviceDataSet terna_TechoserviceDataSet;
        private System.Windows.Forms.BindingSource troubleTypeBindingSource;
        private Terna_TechoserviceDataSetTableAdapters.TroubleTypeTableAdapter troubleTypeTableAdapter;
        private System.Windows.Forms.RichTextBox discriptionBox;
        private Terna_Techoservice1DataSet3 terna_Techoservice1DataSet3;
        private System.Windows.Forms.BindingSource troubleTypeBindingSource1;
        private Terna_Techoservice1DataSet3TableAdapters.TroubleTypeTableAdapter troubleTypeTableAdapter1;
        private System.Windows.Forms.Button feedbackBtn;
    }
}