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
            result.Add(new Groups(Guid.Parse("ac2a862a9f8440d597b8c4188b07c4ed"))
            {
                Name = "Чай"              
            });

            result.Add(new Groups(Guid.Parse("9fca6f4e5e3547d6b59b2325c2fa3fe7"))
            {
                Name = "Кофе"
            });

            result.Add(new Groups(Guid.Parse("043dd2bbe1524149bf13eb5ae9dde160"))
            {
                Name = "Кондитерские изделия"
            });

            return result;

        }

        public Groups getById(Guid id)
        {
            if (Guid.Parse("ac2a862a9f8440d597b8c4188b07c4ed").Equals(id))
            {
                return new Groups(Guid.Parse("ac2a862a9f8440d597b8c4188b07c4ed"))
                {
                    Name = "Чай"                  
                };

            }

            if (Guid.Parse("9fca6f4e5e3547d6b59b2325c2fa3fe7").Equals(id))
            {
                return new Groups(Guid.Parse("9fca6f4e5e3547d6b59b2325c2fa3fe7"))
                {
                    Name = "Кофе"
                };

            }

            if (Guid.Parse("043dd2bbe1524149bf13eb5ae9dde160").Equals(id))
            {
                return new Groups(Guid.Parse("043dd2bbe1524149bf13eb5ae9dde160"))
                {
                    Name = "Кондитерские изделия"
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
