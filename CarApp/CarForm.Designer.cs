namespace CarApp
{
    partial class CarForm
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
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxYearMade = new System.Windows.Forms.TextBox();
            this.textBoxGosNumber = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelYearMade = new System.Windows.Forms.Label();
            this.labelGosNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDateRegistration = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelChekRightWright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(32, 30);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(113, 20);
            this.textBoxModel.TabIndex = 0;
            // 
            // textBoxYearMade
            // 
            this.textBoxYearMade.Location = new System.Drawing.Point(32, 93);
            this.textBoxYearMade.Name = "textBoxYearMade";
            this.textBoxYearMade.Size = new System.Drawing.Size(113, 20);
            this.textBoxYearMade.TabIndex = 1;
            this.textBoxYearMade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYearMade_KeyPress);
            // 
            // textBoxGosNumber
            // 
            this.textBoxGosNumber.Location = new System.Drawing.Point(256, 93);
            this.textBoxGosNumber.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxGosNumber.MinimumSize = new System.Drawing.Size(200, 20);
            this.textBoxGosNumber.Name = "textBoxGosNumber";
            this.textBoxGosNumber.Size = new System.Drawing.Size(200, 20);
            this.textBoxGosNumber.TabIndex = 2;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(32, 13);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(113, 13);
            this.labelModel.TabIndex = 3;
            this.labelModel.Text = "Модель автомобиля:";
            // 
            // labelYearMade
            // 
            this.labelYearMade.AutoSize = true;
            this.labelYearMade.Location = new System.Drawing.Point(32, 77);
            this.labelYearMade.Name = "labelYearMade";
            this.labelYearMade.Size = new System.Drawing.Size(74, 13);
            this.labelYearMade.TabIndex = 4;
            this.labelYearMade.Text = "Год выпуска:";
            // 
            // labelGosNumber
            // 
            this.labelGosNumber.AutoSize = true;
            this.labelGosNumber.Location = new System.Drawing.Point(253, 77);
            this.labelGosNumber.Name = "labelGosNumber";
            this.labelGosNumber.Size = new System.Drawing.Size(68, 13);
            this.labelGosNumber.TabIndex = 5;
            this.labelGosNumber.Text = "Гос. Номер:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата постановки на учет:";
            // 
            // dateTimePickerDateRegistration
            // 
            this.dateTimePickerDateRegistration.Location = new System.Drawing.Point(256, 30);
            this.dateTimePickerDateRegistration.Name = "dateTimePickerDateRegistration";
            this.dateTimePickerDateRegistration.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateRegistration.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(282, 198);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(381, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // labelChekRightWright
            // 
            this.labelChekRightWright.AutoSize = true;
            this.labelChekRightWright.Location = new System.Drawing.Point(50, 147);
            this.labelChekRightWright.Name = "labelChekRightWright";
            this.labelChekRightWright.Size = new System.Drawing.Size(152, 13);
            this.labelChekRightWright.TabIndex = 10;
            this.labelChekRightWright.Text = "введите или заполните поля";
            this.labelChekRightWright.Visible = false;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 262);
            this.Controls.Add(this.labelChekRightWright);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dateTimePickerDateRegistration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelGosNumber);
            this.Controls.Add(this.labelYearMade);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxGosNumber);
            this.Controls.Add(this.textBoxYearMade);
            this.Controls.Add(this.textBoxModel);
            this.MaximumSize = new System.Drawing.Size(502, 300);
            this.MinimumSize = new System.Drawing.Size(502, 300);
            this.Name = "CarForm";
            this.Text = "Форма данных об авто";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelYearMade;
        private System.Windows.Forms.Label labelGosNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        protected internal System.Windows.Forms.TextBox textBoxModel;
        protected internal System.Windows.Forms.TextBox textBoxYearMade;
        protected internal System.Windows.Forms.TextBox textBoxGosNumber;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerDateRegistration;
        private System.Windows.Forms.Label labelChekRightWright;
    }
}