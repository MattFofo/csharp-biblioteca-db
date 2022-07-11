using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Item
    {
        public uint itemCode;
        public string title;
        protected int year;
        protected string sector;
        protected bool isAvaible;
        protected int rack;
        protected string author;

        public Item(uint itemCode, string title, int year, string sector, bool isAvaible, int rack, string author)
        {
            this.itemCode = itemCode;
            this.title = title;
            this.year = year;
            this.sector = sector;
            this.isAvaible = isAvaible;
            this.rack = rack;
            this.author = author;
        }

    }
}
