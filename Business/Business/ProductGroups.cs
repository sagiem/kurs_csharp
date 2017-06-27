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
    public partial class ProductGroups : Form
    {
        private Groups current;//Объявление "текущего товара"
        private GroupsDao groupsDao;//Объявление DAO
    
        public ProductGroups()
        {
            InitializeComponent();
            groupsDao = new GroupsDao();//Инициализация DAO
        }
        //Обработчик загрузки формы
        private void ProductCatalog_Load(object sender, EventArgs e)
        {
            listProductGroups.DataSource = groupsDao.getList();//Получение списка
        }

        //Обработчик выбора элемента в списке
        private void listProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProductGroups.SelectedItem != null)
            {
                current = (Groups)listProductGroups.SelectedItem;//"Текущий товар" указывает на выбранный элемент
                //Заполняем поля на форме
                txtName.Text = current.Name;
            }
        }

        //Обработчик нажатия кнопки "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пользователь нажал кнопку \"Добавить\"");
        }

        //Обработчик нажатия кнопки "Обновить"
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listProductGroups.DataSource = groupsDao.getList();//Получение списка товаров
        }

        //Обработчик нажатия кнопки "Сохранить"
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Сбор данных из полей формы
            current.Name = txtName.Text;

            if (groupsDao.update(current))//Если метод обновление товара вернул "истина"
            {
                MessageBox.Show("Сохранение '" + current.Name + "' успешно");
            }
        }

        //Обработчик нажатия кнопки "Удалить"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (groupsDao.delete(current.Id))//Если метод удаления товара вернул "истина"
            {
                MessageBox.Show("Удаление '" + current.Name + "' успешно");
            }
        }

    }
}
