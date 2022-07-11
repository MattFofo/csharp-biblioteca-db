using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace csharp_biblioteca
{
    internal class User
    {
        private string surname;
        private string name;
        private string email;
        private string password;
        private uint phone;

        protected List<Item> borrowedItems;

        public User(string surname, string name, string email, string password, uint phone)
        {
            string connectionString = "Data Source=localhost;" + "Initial Catalog=db-biblioteca;Integrated Security=True";
            SqlConnection connectionSql = new SqlConnection(connectionString);

            try
            {
                connectionSql.Open();
                string query = "INSERT INTO users (name, surname) values(@name, @surname)";

                using (SqlCommand cmd = new SqlCommand(query, connectionSql))
                {
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@surname", surname));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            this.surname = surname;
            this.name = name;
            this.email = email;
            this.password = password;
            this.phone = phone;
        }
        

        public void borrow()
        {
            string connectionString = "Data Source=localhost;" + "Initial Catalog=db-biblioteca;Integrated Security=True";
            SqlConnection connectionSql = new SqlConnection(connectionString);

            try
            {
                connectionSql.Open();
                string query = "SELECT * FROM users WHERE name=@name";

                using (SqlCommand cmd = new SqlCommand(query, connectionSql))
                {
                    cmd.Parameters.Add(new SqlParameter("@name", this.name));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            Console.WriteLine("utente nel db");

                        }else
                        {
                            Console.WriteLine("utente non trovato");
                        }

                    }
                };


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            connectionSql.Close();
        }
    }
}
