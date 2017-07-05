using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DTO;

namespace Business.DAO
{
    class EmployeesDao
    {
        //Получить список товаров
        public List<Employees> getList()
        {
            List<Employees> result = new List<Employees>();
            //Используется конструктор с одновременной инициализацией поля Value
            result.Add(new Employees(Guid.Parse("04c65c28e4d64dda9439ddfddac7c483"))
            {
                LastName = "Иванов",
                FirstName = "Иван",
                FatherName = "Иванович",
                Gender = "М",
                BirthDate = "25.12.1959",
                Marriage = true,
                PostalIndex = "644050",
                Address = "проезд Ильича, 12-3",
                Position = "CHIEF",
                HireType = "CONST"
            });

            result.Add(new Employees(Guid.Parse("95a4485b7c7143fba582843a704a376e"))
            {
                LastName = "Кузнецова",
                FirstName = "Тамара",
                FatherName = "Ивановна",
                Gender = "Ж",
                BirthDate = "30.08.1969",
                Marriage = true,
                PostalIndex = "644042",
                Address = "Спортивный Проезд, 2-21",
                Position = "CHIEF_ACCOUNTANT",
                HireType = "CONST"
            });

            result.Add(new Employees(Guid.Parse("ebb729718f614ca39d5c3ed7c9400328"))
            {
                LastName = "Петрова",
                FirstName = "Светлана",
                FatherName = "Сергеевна",
                Gender = "Ж",
                BirthDate = "14.02.1975",
                Marriage = false,
                PostalIndex = "644065",
                Address = "ул. Володарская, 22-123",
                Position = " ACCOUNTANT ",
                HireType = "CONST"
            });

            result.Add(new Employees(Guid.Parse("a6e61e149d9149bb846ade9d23353fa5"))
            {
                LastName = "Воронин",
                FirstName = "Сергей",
                FatherName = "Александрович",
                Gender = "М",
                BirthDate = "12.12.1969",
                Marriage = true,
                PostalIndex = "644027",
                Address = "ул. Родионова, 34",
                Position = "AGENT",
                HireType = "TEMP"
            });

            return result;
        }
        //Получить товар по идентификатору
        public Employees getById(Guid id)
        {
            if (Guid.Parse("04c65c28e4d64dda9439ddfddac7c483").Equals(id))
            {
                return new Employees(Guid.Parse("04c65c28e4d64dda9439ddfddac7c483"))
                {
                    LastName = "Иванов",
                    FirstName = "Иван",
                    FatherName = "Иванович",
                    Gender = "М",
                    BirthDate = "25.12.1959",
                    Marriage = true,
                    PostalIndex = "644050",
                    Address = "проезд Ильича, 12-3",
                    Position = "CHIEF",
                    HireType = "CONST"
                };
            }

            if (Guid.Parse("95a4485b7c7143fba582843a704a376e").Equals(id))
            {
                return new Employees(Guid.Parse("95a4485b7c7143fba582843a704a376e"))
                {
                    LastName = "Кузнецова",
                    FirstName = "Тамара",
                    FatherName = "Ивановна",
                    Gender = "Ж",
                    BirthDate = "30.08.1969",
                    Marriage = true,
                    PostalIndex = "644042",
                    Address = "Спортивный Проезд, 2-21",
                    Position = "CHIEF_ACCOUNTANT",
                    HireType = "CONST"
                };
            }

            if (Guid.Parse("ebb729718f614ca39d5c3ed7c9400328").Equals(id))
            {
                return new Employees(Guid.Parse("ebb729718f614ca39d5c3ed7c9400328"))
                {
                    LastName = "Петрова",
                    FirstName = "Светлана",
                    FatherName = "Сергеевна",
                    Gender = "Ж",
                    BirthDate = "14.02.1975",
                    Marriage = false,
                    PostalIndex = "644065",
                    Address = "ул. Володарская, 22-123",
                    Position = " ACCOUNTANT ",
                    HireType = "CONST"
                };
            }

            if (Guid.Parse("a6e61e149d9149bb846ade9d23353fa5").Equals(id))
            {
                return new Employees(Guid.Parse("a6e61e149d9149bb846ade9d23353fa5"))
                {
                    LastName = "Воронин",
                    FirstName = "Сергей",
                    FatherName = "Александрович",
                    Gender = "М",
                    BirthDate = "12.12.1969",
                    Marriage = true,
                    PostalIndex = "644027",
                    Address = "ул. Родионова, 34",
                    Position = "AGENT",
                    HireType = "TEMP"
                };
            }

            return null;
        }
        //Добавить товар в базу данных
        public bool insert(Employees p)
        {
            return true;
        }
        //Удалить товар из базы данных по его идентификатору
        public bool delete(Guid id)
        {
            return true;
        }
        //Обновить данные о товаре в базе данных
        public bool update(Employees p)
        {
            return true;
        }
    }
}
