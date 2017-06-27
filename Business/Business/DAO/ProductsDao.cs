using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DTO;

namespace Business.DAO
{
    public class ProductsDao
    {
        //Получить список товаров
        public List<Product> getList()
        {           
            List<Product> result = new List<Product>();
            //Используется конструктор с одновременной инициализацией поля Value
            result.Add(new Product(Guid.Parse("cc873c2777004d4ea4c8569feb6bb93f"))
            {
                Name = "Принцесса Нури",
                GroupId = Guid.Parse("ac2a862a9f8440d597b8c4188b07c4ed"),
                Unit = "PACK",
                Weight = 0.1m,
                Cost = 12m,
                Quantity = 100
            });
            result.Add(new Product(Guid.Parse("d28cfd5e10144214ab09c37be1771202"))
            {
                Name = "Нескафе Классик",
                GroupId = Guid.Parse("9fca6f4e5e3547d6b59b2325c2fa3fe7"),
                Unit = "TIN_POT",
                Weight = 0.05m,
                Cost = 52m,
                Quantity = 25
            });

            result.Add(new Product(Guid.Parse("b96d685c96c44ab4bcd8c4b212b78895"))
            {
                Name = "кекс Абрикосовый",
                GroupId = Guid.Parse("043dd2bbe1524149bf13eb5ae9dde160"),
                Unit = "UNIT",
                Weight = 0.2m,
                Cost = 24m,
                Quantity = 12
            });
            return result;
        }
        //Получить товар по идентификатору
        public Product getById(Guid id)
        {        
            if (Guid.Parse("cc873c2777004d4ea4c8569feb6bb93f").Equals(id))
            {
                return new Product(Guid.Parse("cc873c2777004d4ea4c8569feb6bb93f"))
                {
                    Name = "Принцесса Нури",
                    GroupId = Guid.Parse("ac2a862a9f8440d597b8c4188b07c4ed"),
                    Unit = "PACK",
                    Weight = 0.1m,
                    Cost = 12m,
                    Quantity = 100
                };
            }
            if (Guid.Parse("d28cfd5e10144214ab09c37be1771202").Equals(id))
            {
                return new Product(Guid.Parse("d28cfd5e10144214ab09c37be1771202"))
                {
                    Name = "Нескафе Классик",
                    GroupId = Guid.Parse("9fca6f4e5e3547d6b59b2325c2fa3fe7"),
                    Unit = "TIN_POT",
                    Weight = 0.05m,
                    Cost = 52m,
                    Quantity = 25
                };
            }
            if (Guid.Parse("b96d685c96c44ab4bcd8c4b212b78895").Equals(id))
            {
                return new Product(Guid.Parse("b96d685c96c44ab4bcd8c4b212b78895"))
                {
                    Name = "кекс Абрикосовый",
                    GroupId = Guid.Parse("043dd2bbe1524149bf13eb5ae9dde160"),
                    Unit = "UNIT",
                    Weight = 0.2m,
                    Cost = 24m,
                    Quantity = 12
                };
            }
            return null;
        }
        //Добавить товар в базу данных
        public bool insert(Product p)
        {
            return true;
        }
        //Удалить товар из базы данных по его идентификатору
        public bool delete(Guid id)
        {
            return true;
        }
        //Обновить данные о товаре в базе данных
        public bool update(Product p)
        {
            return true;
        }
    }

}
