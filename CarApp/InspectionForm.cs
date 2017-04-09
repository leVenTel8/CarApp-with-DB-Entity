using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class InspectionForm : Form
    {
        public InspectionForm()
        {
            InitializeComponent();
        }

        //кнопка перехвата вводимых значений и проверка на string
        private void textBoxYearMade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!labelNeedWriteInt.Visible)
            {
                labelNeedWriteInt.Text = "   ";
                labelNeedWriteInt.Visible = true;
            }

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
            {
                e.Handled = true;
                labelNeedWriteInt.Text = "   ";
                labelNeedWriteInt.Visible = false;
                MessageBox.Show("Введите число в поле <Номер ТО>!");

            }
        }

        //кнопка проверки заполнения формы + DialogResult OK
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNumberInspection.Text) && !string.IsNullOrWhiteSpace(textBoxNumberInspection.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Заполните пустые поля!");
                return;
            }
        }

    }
}
