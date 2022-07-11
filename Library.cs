using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace csharp_biblioteca
{
    internal class Library
    {
        protected List<User> users = new List<User>();
        public List<Item> items = new List<Item>();

        public Library(List<User> users, List<Item> items)
        {
            this.users = users;
            this.items = items;
        }

        //public Item SearchItem(string title)
        //{
        //    Item result = null;
        //    foreach (var item in items)
        //    {

        //        if (item.title.Contains(title))
        //        {
        //            result = item;
        //            break;

        //        }
        //        else
        //        {
        //            result = null;
        //        }
        //    }
        //    return result;
        //}

        public void SearchItem(string title)
        {
            string connectionString = "Data Source=localhost;" + "Initial Catalog=db-biblioteca;Integrated Security=True";
            SqlConnection connectionSql = new SqlConnection(connectionString);


            try
            {
                connectionSql.Open();
                string query = "SELECT library_code, title FROM copies inner join books on copies.book_id = books.id where books.title=@title";

                using (SqlCommand cmd = new SqlCommand(query, connectionSql))
                {
                    cmd.Parameters.Add(new SqlParameter("@title", title));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            Console.WriteLine("Titolo " + reader.GetString(1));
                            Console.WriteLine("Codice: " + reader.GetString(0));
                        }

                    }
                };


            }
            catch (Exception)
            {

                throw;
            }

            //connectionSql.Close();

            //Item result = null;
            //foreach (var item in items)
            //{

            //    if (item.title.Contains(title))
            //    {
            //        result = item;
            //        break;

            //    }
            //    else
            //    {
            //        result = null;
            //    }
            //}
            //return result;
        }

        public Item SearchItem(uint itemCode)
        {
            Item result = null;
            foreach (var item in items)
            {

                if (item.itemCode == itemCode)
                {
                    result = item;
                    break;

                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public void PrintSearchResult(Item result)
        {
            if (result != null)
            {
                Console.WriteLine(result.title);

            }
            else
            {
                Console.WriteLine("nessun risultato");

            }
        }
    }
}
