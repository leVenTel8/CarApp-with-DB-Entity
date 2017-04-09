namespace CarApp
{
    partial class ReportCarForm
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
            this.labelTotalCars = new System.Windows.Forms.Label();
            this.labelCarsOldThreeYear = new System.Windows.Forms.Label();
            this.labelCarsYongThreeYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotalCars
            // 
            this.labelTotalCars.AutoSize = true;
            this.labelTotalCars.Location = new System.Drawing.Point(31, 28);
            this.labelTotalCars.Name = "labelTotalCars";
            this.labelTotalCars.Size = new System.Drawing.Size(63, 13);
            this.labelTotalCars.TabIndex = 0;
            this.labelTotalCars.Text = "Всего авто";
            // 
            // labelCarsOldThreeYear
            // 
            this.labelCarsOldThreeYear.AutoSize = true;
            this.labelCarsOldThreeYear.Location = new System.Drawing.Point(31, 72);
            this.labelCarsOldThreeYear.Name = "labelCarsOldThreeYear";
            this.labelCarsOldThreeYear.Size = new System.Drawing.Size(161, 13);
            this.labelCarsOldThreeYear.TabIndex = 1;
            this.labelCarsOldThreeYear.Text = "Количество авто старше 3 лет";
            // 
            // labelCarsYongThreeYear
            // 
            this.labelCarsYongThreeYear.AutoSize = true;
            this.labelCarsYongThreeYear.Location = new System.Drawing.Point(31, 114);
            this.labelCarsYongThreeYear.Name = "labelCarsYongThreeYear";
            this.labelCarsYongThreeYear.Size = new System.Drawing.Size(164, 13);
            this.labelCarsYongThreeYear.TabIndex = 2;
            this.labelCarsYongThreeYear.Text = "Количество авто младше 3 лет";
            // 
            // ReportCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 171);
            this.Controls.Add(this.labelCarsYongThreeYear);
            this.Controls.Add(this.labelCarsOldThreeYear);
            this.Controls.Add(this.labelTotalCars);
            this.MaximumSize = new System.Drawing.Size(290, 209);
            this.MinimumSize = new System.Drawing.Size(290, 209);
            this.Name = "ReportCarForm";
            this.Text = "ReportCarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label labelTotalCars;
        protected internal System.Windows.Forms.Label labelCarsOldThreeYear;
        protected internal System.Windows.Forms.Label labelCarsYongThreeYear;

    }
}