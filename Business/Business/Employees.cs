using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.DAO;
using Business.DTO;

namespace Business
{
    public partial class EmployeesCatalog : Form
    {
        private Employees current;
        private EmployeesDao employeesDao;

        public EmployeesCatalog()
        {
            InitializeComponent();
            employeesDao = new EmployeesDao();
        }
        //Обработчик загрузки формы
        private void ProductCatalog_Load(object sender, EventArgs e)
        {
            listEmployees.DataSource = employeesDao.getList();//Получение списка товаров
        }

        //Обработчик выбора элемента в списке
        private void listProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            current = (Employees)listEmployees.SelectedItem;//"Текущий товар" указывает на выбранный элемент
                                                            //Заполняем поля на форме
            txtFirstName.Text = current.FirstName;
            txtLastName.Text = current.LastName;
            txtFatherName.Text = current.FatherName;
            txtFatherName.Text = current.FatherName;
            cmbGender.SelectedItem = current.Gender;
            txtBirthDate.Text = current.BirthDate;
            chkMarriage.Checked = current.Marriage;
            txtPostalIndex.Text = current.PostalIndex;
            txtAddress.Text = current.Address;
            txtPosition.Text = current.Position;
            cmbHireType.SelectedItem = current.HireType;


        }

        //Обработчик нажатия кнопки "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пользователь нажал кнопку \"Добавить\"");
        }

        //Обработчик нажатия кнопки "Обновить"
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listEmployees.DataSource = employeesDao.getList();//Получение списка товаров
        }

        //Обработчик нажатия кнопки "Сохранить"
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Сбор данных из полей формы
             current.FirstName = txtFirstName.Text;
             current.LastName = txtLastName.Text;
             current.FatherName = txtFatherName.Text;
             current.FatherName = txtFatherName.Text;
             current.Gender = cmbGender.SelectedItem.ToString();
             current.BirthDate = txtBirthDate.Text;
             current.Marriage= chkMarriage.Checked;
             current.PostalIndex = txtPostalIndex.Text;
             current.Address = txtAddress.Text;
             current.Position = txtPosition.Text;
             current.HireType = cmbHireType.SelectedItem.ToString();

            if (employeesDao.update(current))//Если метод обновление товара вернул "истина"
            {
                MessageBox.Show("Сохранение '" + current.FirstName + "' успешно");
            }
        }

        //Обработчик нажатия кнопки "Удалить"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление '" + current.LastName + "' успешно");
        }

        private void chkMarriage_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
