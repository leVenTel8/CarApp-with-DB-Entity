using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Entity;
using CarApp.DataModel;


namespace CarApp
{
    public partial class MainForm : Form
    {
        CarContext db;

        public MainForm()
        {
            InitializeComponent();

            db = new CarContext();
            db.Cars.Load();
            db.Inspections.Load();

            dataGridViewMainForm.DataSource = db.Cars.Local.ToBindingList();

        }

        // кнопка добавления объекта Car на главную форму
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CarForm frmAddCar = new CarForm();
            DialogResult result = frmAddCar.ShowDialog(this);                            

            if (result == DialogResult.Cancel)
                return;

            Car car = new Car();
            car.Model = frmAddCar.textBoxModel.Text;
            car.YearMade = Convert.ToInt32(frmAddCar.textBoxYearMade.Text);
            car.GosNumber = frmAddCar.textBoxGosNumber.Text;
            car.DateRegistration = frmAddCar.dateTimePickerDateRegistration.Text;

            db.Cars.Add(car);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");
            MessageBox.Show("Новый объект добавлен");
        }

        // кнопка редактирования объекта Car на главной форме
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMainForm.SelectedRows.Count > 0)
            {
                int index = dataGridViewMainForm.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewMainForm[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                Car car = db.Cars.Find(id);
              
                CarForm frmEditCar = new CarForm();

                frmEditCar.textBoxModel.Text = car.Model;
                frmEditCar.textBoxYearMade.Text = Convert.ToString(car.YearMade);
                frmEditCar.textBoxGosNumber.Text = car.GosNumber;
                frmEditCar.dateTimePickerDateRegistration.Text = car.DateRegistration;

                DialogResult result = frmEditCar.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                car.Model = frmEditCar.textBoxModel.Text;
                car.YearMade = Convert.ToInt32(frmEditCar.textBoxYearMade.Text);
                car.GosNumber = frmEditCar.textBoxGosNumber.Text;
                car.DateRegistration = frmEditCar.dateTimePickerDateRegistration.Text;

                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                dataGridViewMainForm.Refresh(); // обновляем грид
                MessageBox.Show("Объект обновлен");

            }
        }

        // кнопка удаления объекта Car с главной формы
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMainForm.SelectedRows.Count > 0)
            {

                int index = dataGridViewMainForm.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewMainForm[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                db.Inspections.Load();
                Car car = db.Cars.Find(id);

                db.Cars.Remove(car);
                db.SaveChanges();

                MessageBox.Show("Объект удален");

            }
        }

        //кнопка отчета по таблице MainForm
        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportCarForm frmRepCar = new ReportCarForm();

            DateTime curdate = DateTime.Now;                                                
            int year = curdate.Year;
            int ThreeYear = year - 3;

            int size = db.Cars.Count();
            frmRepCar.labelTotalCars.Text = "Всего автомобилей: " + Convert.ToString(size);

            var user = db.Cars.Where(p => p.YearMade < ThreeYear);
            int nElems = user.Count();
            frmRepCar.labelCarsOldThreeYear.Text = "Количество автомобилей старше 3 лет:" + Convert.ToString(nElems);

            var user1 = db.Cars.Where(p => p.YearMade > ThreeYear);
            int nEl = user1.Count();
            frmRepCar.labelCarsYongThreeYear.Text = "Количество автомобилей младше 3 лет:" + Convert.ToString(nEl);

            DialogResult result = frmRepCar.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
                
        }

        // кнопка вызова второй формы с номерами ТО, привязанными к одному объекту Car
        private void btnEditInspection_Click(object sender, EventArgs e)
        {
              InspectionTableForm frmInsTab = new InspectionTableForm(this.dataGridViewMainForm[0, dataGridViewMainForm.CurrentRow.Index].Value.ToString());
              frmInsTab.Show();

        }
    }
}
