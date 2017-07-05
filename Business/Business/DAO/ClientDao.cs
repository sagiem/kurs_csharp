using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DTO;

namespace Business.DAO
{
    class ClientDao
    {
        public List<Client> getList()
        {
            List<Client> result = new List<Client>();
            result.Add(new Client(Guid.Parse("f20464cb2c6b4f8db1dd3cef77ea2e35"))
            {
                Name = "ООО \"Рога и копыта\""
            });

            result.Add(new Client(Guid.Parse("0b027250e1e14a5c887ec462f1a2d875"))
            {
                Name = "магазин \"Колос\""
            });

            result.Add(new Client(Guid.Parse("10eb0fdc33784f35b7855332c6f54ddb"))
            {
                Name = "кафе \"Три толстяка\""
            });

            result.Add(new Client(Guid.Parse("2963c311fa64492dac12a7916f01e963"))
            {
                Name = "ЧП А. А. Соснов"
            });

            return result;

        }

        public Client getById(Guid id)
        {
            if (Guid.Parse("f20464cb2c6b4f8db1dd3cef77ea2e35").Equals(id))
            {
                return new Client(Guid.Parse("f20464cb2c6b4f8db1dd3cef77ea2e35"))
                {
                    Name = "ООО \"Рога и копыта\""
                };

            }

            if (Guid.Parse("0b027250e1e14a5c887ec462f1a2d875").Equals(id))
            {
                return new Client(Guid.Parse("0b027250e1e14a5c887ec462f1a2d875"))
                {
                    Name = "магазин \"Колос\""
                };

            }

            if (Guid.Parse("10eb0fdc33784f35b7855332c6f54ddb").Equals(id))
            {
                return new Client(Guid.Parse("10eb0fdc33784f35b7855332c6f54ddb"))
                {
                    Name = "кафе \"Три толстяка\""
                };

            }

            if (Guid.Parse("2963c311fa64492dac12a7916f01e963").Equals(id))
            {
                return new Client(Guid.Parse("2963c311fa64492dac12a7916f01e963"))
                {
                    Name = "ЧП А. А. Соснов"
                };

            }

            return null;
        }

        //Добавить группу в базу данных
        public bool insert(Client p)
        {
            return true;
        }
        //Удалить группу из базы данных по его идентификатору
        public bool delete(Guid id)
        {
            return true;
        }
        //Обновить данные о группе в базе данных
        public bool update(Client p)
        {
            return true;
        }
    }
}
