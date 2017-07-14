using Business.DAO;
using Business.DTO;
using Business.view;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Business.presenter
{
    public class ProductCatalogPresenter
    {
        private ProductsDao productDao;    //Ссылка на dao
        private ProductCatalog view;    //Ссылка на представление
        private List<Product> cached = new List<Product>();//Коллекция для хранения полного списка товаров из базы
        private String filter = "";    //Фильтр по-умолчанию

        //Презентер не имеет смысла без представления(формы).
        //Поэтому ссылка на форму должна передаваться при создании презентера
        public ProductCatalogPresenter(ProductCatalog view)
        {
            //Нужно проверить наличие объекта по ссылке
            if (view == null)
            {
                throw new ArgumentException("Представление не инициализировано");
            }
            this.view = view;
            productDao = new ProductsDao();
        }

        //Загрузка списка товаров. Будет вызываться при запуске приложения и вручную по требованию
        //Тип возвращаемого значения void потому что результат работы презентера - вызов команд представления
        public void loadProducts()
        {
            //Загружаем список товаров из базы
            cached = productDao.getList();
            //Фильтрум данные и командуем представлению "отобрази список"
            displayFilteredProducts();
        }

        //Фильтрация списка товаров
        public void filterWith(String value)
        {
            //Запоминаем фильтр и преобразуем в нижний регистр
            filter = value.ToLower();
            //Фильтрум данные и командуем представлению "отобрази список"
            displayFilteredProducts();
        }

        //Загрузка списка товаров может запускаться вручную.
        //Это значит, что может случиться ситуация когда пользователь задал фильтр и вызвал обновление.
        //В этом случае фильтр нужно применять к загруженным данным
        private void displayFilteredProducts()
        {
            if (!String.IsNullOrWhiteSpace(filter))
            {
                List<Product> filtered = new List<Product>();
                //Просто перебираем все товары и заполняем новый список.
                foreach (Product p in cached)
                {
                    //Сравниваем наименования в нижнем регистре
                    if (p.Name.ToLower().Contains(filter))
                    {
                        filtered.Add(p);
                    }
                }
                //Очищаем поля формы
                view.clearFields();
                //У представления будет ссылка на коллекцию, а значит будет возможность добавлять и удалять товары из этого списка
                //Но подобные действия должны проводиться только через презентер
                //Поэтому презентер возвращает коллекцию с доступом "только для чтения"
                view.displayProducts(new ReadOnlyCollection<Product>(filtered));
            }
            else
            {
                view.displayProducts(new ReadOnlyCollection<Product>(cached));
            }
        }
    }
}