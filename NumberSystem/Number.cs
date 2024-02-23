using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem
{
    public  class Number
    {
        int num;
        public Number(int num)
        {
                this.num = num;
        }
        public string EvenOrOdd()
        {
            if (num %2==0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
}
