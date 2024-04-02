namespace Technoservice
{
    partial class ReportForm
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
            this.CreateRepBtn = new System.Windows.Forms.Button();
            this.troubleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terna_Techoservice1DataSet12 = new Technoservice.Terna_Techoservice1DataSet12();
            this.logoLabel = new System.Windows.Forms.Label();
            this.troubleTableAdapter = new Technoservice.Terna_Techoservice1DataSet12TableAdapters.TroubleTableAdapter();
            this.reportBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.troubleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateRepBtn
            // 
            this.CreateRepBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateRepBtn.Location = new System.Drawing.Point(121, 281);
            this.CreateRepBtn.Name = "CreateRepBtn";
            this.CreateRepBtn.Size = new System.Drawing.Size(149, 55);
            this.CreateRepBtn.TabIndex = 0;
            this.CreateRepBtn.Text = "Сформировать отчет";
            this.CreateRepBtn.UseVisualStyleBackColor = true;
            this.CreateRepBtn.Click += new System.EventHandler(this.CreateRepBtn_Click);
            // 
            // troubleBindingSource
            // 
            this.troubleBindingSource.DataMember = "Trouble";
            this.troubleBindingSource.DataSource = this.terna_Techoservice1DataSet12;
            // 
            // terna_Techoservice1DataSet12
            // 
            this.terna_Techoservice1DataSet12.DataSetName = "Terna_Techoservice1DataSet12";
            this.terna_Techoservice1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.Location = new System.Drawing.Point(114, -3);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(156, 20);
            this.logoLabel.TabIndex = 9;
            this.logoLabel.Text = "ООО \"Техносервис\"";
            // 
            // troubleTableAdapter
            // 
            this.troubleTableAdapter.ClearBeforeFill = true;
            // 
            // reportBox
            // 
            this.reportBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.troubleBindingSource, "trouble_id", true));
            this.reportBox.DataSource = this.troubleBindingSource;
            this.reportBox.DisplayMember = "trouble_id";
            this.reportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportBox.FormattingEnabled = true;
            this.reportBox.Location = new System.Drawing.Point(129, 177);
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(121, 28);
            this.reportBox.TabIndex = 19;
            this.reportBox.ValueMember = "trouble_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Выберите номер записи";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.reportBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateRepBtn);
            this.Controls.Add(this.logoLabel);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.troubleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_Techoservice1DataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateRepBtn;
        private System.Windows.Forms.Label logoLabel;
        private Terna_Techoservice1DataSet12 terna_Techoservice1DataSet12;
        private System.Windows.Forms.BindingSource troubleBindingSource;
        private Terna_Techoservice1DataSet12TableAdapters.TroubleTableAdapter troubleTableAdapter;
        private System.Windows.Forms.ComboBox reportBox;
        private System.Windows.Forms.Label label3;
    }
}