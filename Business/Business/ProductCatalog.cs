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
    public partial class ProductCatalog : Form
    {
        private Product current;//Объявление "текущего товара"
        private ProductsDao productDao;//Объявление DAO

        public ProductCatalog()
        {
            InitializeComponent();
            productDao = new ProductsDao();//Инициализация DAO
        }

        //Обработчик загрузки формы
        private void ProductCatalog_Load(object sender, EventArgs e)
        {
            listProducts.DataSource = productDao.getList();//Получение списка товаров
        }

        //Обработчик выбора элемента в списке
        private void listProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProducts.SelectedItem != null)
            {
                current = (Product)listProducts.SelectedItem;//"Текущий товар" указывает на выбранный элемент
                //Заполняем поля на форме
                txtName.Text = current.Name;
                cmbUnit.SelectedItem = current.Unit;
                txtCost.Text = current.Cost.ToString();
                txtQuantity.Text = current.Quantity.ToString();
                cmbProductGroup.Text = current.GroupId.ToString();
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
            listProducts.DataSource = productDao.getList();//Получение списка товаров
        }

        //Обработчик нажатия кнопки "Сохранить"
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Сбор данных из полей формы
            current.Name = txtName.Text;
            current.Unit = cmbUnit.SelectedItem.ToString();
            current.Cost = Decimal.Parse(txtCost.Text);
            current.Quantity = Int32.Parse(txtQuantity.Text);
            current.GroupId = Guid.Parse(cmbProductGroup.Text);
            if (productDao.update(current))//Если метод обновление товара вернул "истина"
            {
                MessageBox.Show("Сохранение '" + current.Name + "' успешно");
            }
        }

        //Обработчик нажатия кнопки "Удалить"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productDao.delete(current.Id))//Если метод удаления товара вернул "истина"
            {
                MessageBox.Show("Удаление '" + current.Name + "' успешно");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
