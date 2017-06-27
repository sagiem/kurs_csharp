using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Business
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //Создание нового экземпляра формы
            ProductCatalog productsCatalog = new ProductCatalog();
            //Отображение созданной формы на экране
            productsCatalog.Show();
        }

        private void btnEmployees_Click_1(object sender, EventArgs e)
        {
            EmployeesCatalog employeesCatalog = new EmployeesCatalog();
            employeesCatalog.Show();
        }

        private void btnProductGroups_Click_1(object sender, EventArgs e)
        {
            ProductGroups productGroups = new ProductGroups();
            productGroups.Show();
        }

        private void btnClientCatalog_Click(object sender, EventArgs e)
        {
            ClientCatalog clientCatalog = new ClientCatalog();
            clientCatalog.Show();
        }
    }
}