using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DTO;
using Npgsql;
using NpgsqlTypes;

namespace Business.DAO
{
    public class ClientDao
    {

        private static String GET_LIST_CMD =
@"SELECT
clientid
checkingaccount
inn
name
FROM clients;";

        private static String GET_SINGLE_CMD =
@"SELECT
clientid
checkingaccount
inn
name
FROM clients WHERE clientid=:id;";

        private static String INSERT_CMD =
@"INSERT INTO products(clientid, checkingaccount, inn, name)
VALUES (:Id, :checkingaccount, :inn, :name);";

        private static String UPDATE_CMD =
@"UPDATE clients
SET clientid = :Id,
checkingaccount = :checkingaccount,
inn = :inn,
name = :name,
WHERE clientid = :id;";

        private static String DELETE_CMD =
@"DELETE FROM products WHERE clientid = :id";

        public List<Client> getList()
        {
            List<Client> result = new List<Client>();
            NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=business;Password=business;Database=business");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(GET_LIST_CMD, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Конструируем объект из данных в текущей строке
                Client temp = new Client(reader.GetGuid(0));//Получаем значение типа GUID из первой колонки
                temp.checkingaccount = reader.GetString(1);//Получаем строковое значение из второй колонки
                temp.inn = reader.GetString(2);
                temp.Name = reader.GetString(3);
             
                result.Add(temp);//Добавляем сконструированный объект к результату
            }
            connection.Close();


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
            NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=business;Password=business;Database=business");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(INSERT_CMD, connection);
            cmd.Parameters.Add(new NpgsqlParameter(":id", NpgsqlDbType.Uuid) { Value = Guid.NewGuid() });
            cmd.Parameters.Add(new NpgsqlParameter(":checkingaccount", NpgsqlDbType.Text) { Value = p.checkingaccount });
            cmd.Parameters.Add(new NpgsqlParameter(":inn", NpgsqlDbType.Text) { Value = p.inn });
            cmd.Parameters.Add(new NpgsqlParameter(":name", NpgsqlDbType.Text) { Value = p.Name });           
            bool result = cmd.ExecuteNonQuery() == 1;//Проверяется количество измененных строк
            connection.Close();//Закрывается подключение
            return result;
            //Если вставилось 0 строк, значит запрос выполнился некорректно

        }
        //Удалить группу из базы данных по его идентификатору
        public bool delete(Guid id)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=business;Password=business;Database=business");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(DELETE_CMD, connection);
            cmd.Parameters.Add(new NpgsqlParameter(":id", NpgsqlDbType.Uuid) { Value = id });
            bool result = cmd.ExecuteNonQuery() == 1;
            connection.Close();
            return result;
        }
        //Обновить данные о группе в базе данных
        public bool update(Client p)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=business;Password=business;Database=business");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(UPDATE_CMD, connection);
            cmd.Parameters.Add(new NpgsqlParameter(":id", NpgsqlDbType.Uuid) { Value = p.Id });
            cmd.Parameters.Add(new NpgsqlParameter(":checkingaccount", NpgsqlDbType.Text) { Value = p.checkingaccount });
            cmd.Parameters.Add(new NpgsqlParameter(":inn", NpgsqlDbType.Text) { Value = p.inn });
            cmd.Parameters.Add(new NpgsqlParameter(":name", NpgsqlDbType.Text) { Value = p.Name });
            bool result = cmd.ExecuteNonQuery() == 1;
            connection.Close();
            return result;
        }
    }
}
