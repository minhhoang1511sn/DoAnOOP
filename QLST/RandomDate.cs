using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class RandomDate
    {
        public static Random Rnd = new Random();

        public DateTime RandomDateTime()
        {
            DateTime start = new DateTime(2000, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(Rnd.Next(range));
        }
    }
}