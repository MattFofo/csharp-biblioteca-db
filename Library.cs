using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Item SearchItem(string title)
        {
            Item result = null;
            foreach (var item in items)
            {

                if (item.title.Contains(title))
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
