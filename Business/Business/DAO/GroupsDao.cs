using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DTO;

namespace Business.DAO
{
    public class GroupsDao
    {
        public List<Groups> getList()
        {
            List<Groups> result = new List<Groups>();
            result.Add(new Groups(Guid.Parse("cc873c2777004d4ea4c8569feb6bb93b"))
            {
                Name = "Чай"              
            });

            return result;

        }

        public Groups getById(Guid id)
        {
            if (Guid.Parse("cc873c2777004d4ea4c8569feb6bb93b").Equals(id))
            {
                return new Groups(Guid.Parse("cc873c2777004d4ea4c8569feb6bb93b"))
                {
                    Name = "Чай"                  
                };

            }

            return null;
        }

        //Добавить группу в базу данных
        public bool insert(Groups p)
        {
            return true;
        }
        //Удалить группу из базы данных по его идентификатору
        public bool delete(Guid id)
        {
            return true;
        }
        //Обновить данные о группе в базе данных
        public bool update(Groups p)
        {
            return true;
        }
    }
}
