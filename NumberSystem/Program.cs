using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(11);
            Console.WriteLine(number.EvenOrOdd());
            Console.WriteLine("-----------------");
            // for student

            Student st = new Student("RAMKUMAR","Tenth", 100, 100, 100, 100, 100);
            Console.WriteLine("Name :"+st.Name);
            Console.WriteLine("standard :"+st.Std);
            Console.WriteLine("Total Mark :" + st.TotalMark());
            Console.WriteLine("Percentage :" + Math.Round(st.Percentage()));
            st.Grade();
            Console.ReadKey();
        }
    }
}
