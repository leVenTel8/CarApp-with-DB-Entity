namespace CarApp
{
    partial class InspectionForm
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
            this.labelNeedWriteInt = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.labelDateInspection = new System.Windows.Forms.Label();
            this.dateTimePickerDateInspection = new System.Windows.Forms.DateTimePicker();
            this.labelNumberInspection = new System.Windows.Forms.Label();
            this.textBoxNumberInspection = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNeedWriteInt
            // 
            this.labelNeedWriteInt.AutoSize = true;
            this.labelNeedWriteInt.ForeColor = System.Drawing.Color.Red;
            this.labelNeedWriteInt.Location = new System.Drawing.Point(271, 86);
            this.labelNeedWriteInt.Name = "labelNeedWriteInt";
            this.labelNeedWriteInt.Size = new System.Drawing.Size(140, 13);
            this.labelNeedWriteInt.TabIndex = 15;
            this.labelNeedWriteInt.Text = "Необходимо ввести число";
            this.labelNeedWriteInt.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(353, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(255, 211);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelDateInspection
            // 
            this.labelDateInspection.AutoSize = true;
            this.labelDateInspection.Location = new System.Drawing.Point(11, 16);
            this.labelDateInspection.Name = "labelDateInspection";
            this.labelDateInspection.Size = new System.Drawing.Size(51, 13);
            this.labelDateInspection.TabIndex = 11;
            this.labelDateInspection.Text = "Дата ТО";
            // 
            // dateTimePickerDateInspection
            // 
            this.dateTimePickerDateInspection.Location = new System.Drawing.Point(12, 43);
            this.dateTimePickerDateInspection.Name = "dateTimePickerDateInspection";
            this.dateTimePickerDateInspection.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateInspection.TabIndex = 10;
            // 
            // labelNumberInspection
            // 
            this.labelNumberInspection.AutoSize = true;
            this.labelNumberInspection.Location = new System.Drawing.Point(271, 16);
            this.labelNumberInspection.Name = "labelNumberInspection";
            this.labelNumberInspection.Size = new System.Drawing.Size(59, 13);
            this.labelNumberInspection.TabIndex = 9;
            this.labelNumberInspection.Text = "Номер ТО";
            // 
            // textBoxNumberInspection
            // 
            this.textBoxNumberInspection.Location = new System.Drawing.Point(274, 43);
            this.textBoxNumberInspection.Name = "textBoxNumberInspection";
            this.textBoxNumberInspection.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberInspection.TabIndex = 8;
            this.textBoxNumberInspection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYearMade_KeyPress);
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 262);
            this.Controls.Add(this.labelNeedWriteInt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelDateInspection);
            this.Controls.Add(this.dateTimePickerDateInspection);
            this.Controls.Add(this.labelNumberInspection);
            this.Controls.Add(this.textBoxNumberInspection);
            this.MaximumSize = new System.Drawing.Size(472, 300);
            this.MinimumSize = new System.Drawing.Size(472, 300);
            this.Name = "InspectionForm";
            this.Text = "InspectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNeedWriteInt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labelDateInspection;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerDateInspection;
        private System.Windows.Forms.Label labelNumberInspection;
        protected internal System.Windows.Forms.TextBox textBoxNumberInspection;
    }
}