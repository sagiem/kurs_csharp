﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    public class Groups
    {
        public Groups(Guid id)//Вынуждаем передавать идентификатор при создании объекта
        {
            this.Id = id;
        }

        public Guid Id { get; private set; } //Запрещаем изменение
        public String Name { get; set; }
        

        public override string ToString()
        {
            return Name;
        }
    }
}
