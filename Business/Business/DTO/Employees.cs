using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    class Employees
    {
        public Employees(Guid id)//Вынуждаем передавать идентификатор при создании объекта
        {
            this.Id = id;
        }

        public Guid Id { get; private set; } //Запрещаем изменение
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String FatherName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public bool Marriage { get; set; }
        public string PostalIndex { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public string HireType { get; set; }

        public override string ToString()
        {
            return LastName;
        }
    }
}
