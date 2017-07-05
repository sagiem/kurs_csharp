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
    public partial class ClientCatalog : Form
    {
        private Client current;//Объявление "текущего клиента"
        private ClientDao clientDao;//Объявление DAO

        public ClientCatalog()
        {
            InitializeComponent();
            clientDao = new ClientDao();
        }

        //Обработчик загрузки формы
        private void ProductCatalog_Load(object sender, EventArgs e)
        {
            listClients.DataSource = clientDao.getList();//Получение списка
        }

        //Обработчик выбора элемента в списке
        private void listProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listClients.SelectedItem != null)
            {
                current = (Client)listClients.SelectedItem;//"Текущий товар" указывает на выбранный элемент
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
            listClients.DataSource = clientDao.getList();//Получение списка
        }

        //Обработчик нажатия кнопки "Сохранить"
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Сбор данных из полей формы
            current.Name = txtName.Text;

            if (clientDao.update(current))//Если метод обновление товара вернул "истина"
            {
                MessageBox.Show("Сохранение '" + current.Name + "' успешно");
            }
        }

        //Обработчик нажатия кнопки "Удалить"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clientDao.delete(current.Id))//Если метод удаления товара вернул "истина"
            {
                MessageBox.Show("Удаление '" + current.Name + "' успешно");
            }
        }

    }
}
