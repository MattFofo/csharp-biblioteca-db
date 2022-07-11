using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Item
    {
        protected int duration;
        protected uint serialNumber;

        public Dvd(uint SN, int duration, string title, int year, string sector, bool isAvaible, int rack, string author) : base(SN, title, year, sector, isAvaible, rack, author)
        {
            this.duration = duration;
            this.serialNumber = SN;
        }
    }
}
