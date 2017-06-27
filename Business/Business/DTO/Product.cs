using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    class Product
    {
        public Product(Guid id)//Вынуждаем передавать идентификатор при создании объекта
        {
            this.Id = id;
        }

        public Guid Id { get; private set; } //Запрещаем изменение
        public String Name { get; set; }
        public String Unit { get; set; }
        public String GroupId { get; set; }
        public Decimal Cost { get; set; }
        public int Quantity { get; set; }
        public Decimal Weight { get; set; }

    }
}
