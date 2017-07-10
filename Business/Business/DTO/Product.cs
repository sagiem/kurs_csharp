using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    public class Product
    {
        public Product(Guid id)//Вынуждаем передавать идентификатор при создании объекта
        {
            this.Id = id;
        }

        public Guid Id { get; private set; } //Запрещаем изменение
        public String Name { get; set; }
        public String Unit { get; set; }
        public Guid GroupId { get; set; }
        public Decimal Cost { get; set; }
        public int Quantity { get; set; }
        public float Weight { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
