using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business
{
    public partial class ProductCatalog : Form
    {
        public ProductCatalog()
        {
            InitializeComponent();
        }

        //Обработчик загрузки формы
        private void ProductCatalog_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Форма загрузилась");
        }

        //Обработчик выбора элемента в списке
        private void listProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Простое сообщение пользователю
            MessageBox.Show("Пользователь выбрал элемент списка");
        }

        //Обработчик нажатия кнопки "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пользователь нажал кнопку \"Добавить\"");
        }

        //Обработчик нажатия кнопки "Обновить"
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пользователь нажал кнопку \"Обновить\"");
        }

        //Обработчик нажатия кнопки "Сохранить"
        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пользователь нажал кнопку \"Сохранить\"");
        }

        //Обработчик нажатия кнопки "Удалить"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пользователь нажал кнопку \"Удалить\"");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
