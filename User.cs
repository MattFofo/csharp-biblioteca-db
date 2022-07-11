using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.surname = surname;
            this.name = name;
            this.email = email;
            this.password = password;
            this.phone = phone;
        }
        

        public void borrow()
        {

        }
    }
}
