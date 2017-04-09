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
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        // кнопка подтверждения действий с проверкой на пустые поля
        private void btnOK_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxModel.Text) && !string.IsNullOrWhiteSpace(textBoxModel.Text) &&
                !string.IsNullOrEmpty(textBoxYearMade.Text) && !string.IsNullOrWhiteSpace(textBoxYearMade.Text) &&
                !string.IsNullOrEmpty(textBoxGosNumber.Text) && !string.IsNullOrWhiteSpace(textBoxGosNumber.Text))
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

        //перехват вводимых символов в поле textBoxYearMade и проверка на тип string
        private void textBoxYearMade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!labelChekRightWright.Visible)
            {
                labelChekRightWright.Text = "   ";
                labelChekRightWright.Visible = true;
            }


            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
            {
                e.Handled = true;
                labelChekRightWright.Text = "   ";
                labelChekRightWright.Visible = false;
                MessageBox.Show("Гос. номер должен быть заполнен цифрами!");
               
            }
        }
    }
}
