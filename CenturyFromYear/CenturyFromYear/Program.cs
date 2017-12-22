using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuryFromYear(int year)
            {
                int century;
                if (year % 100 == 0)
                {
                    century = year / 100;
                }
                else
                {
                    century = year / 100 + 1;
                }
                return century;
            }

        }
    }
}
