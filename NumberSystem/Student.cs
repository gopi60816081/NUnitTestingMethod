using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem
{
    public class Student
    {
        
        public string Name { get; set; }
        public string Std { get; set; }
        public double Tmark { get; set; }
        public double Emark { get; set; }
        public double Mmark { get; set; }
        public double Smark { get; set; }
        public double SSmark { get; set; }

        public Student(string n,string std, double T, double E, double M, double S, double SS)
        {
            Name = n;
            Std = std;
            Tmark = T;
            Emark = E;
            Mmark = M;
            Smark = S; 
            SSmark = SS;


        }
        public double TotalMark()
        {
            return Tmark + Emark + Mmark+Smark+ SSmark;
           
        }
        public double Percentage()
        {
            var Total = TotalMark();
            var Perc = Total/5;
            return Perc;
        }
        public string Grade()
        {
            int passMark = 40;
            var Perc = Percentage();
            if (Tmark >= passMark && Emark >= passMark && Mmark >= passMark && Smark >= passMark && SSmark >= passMark)
            {
                if(Perc >= 80)
                {
                    Console.WriteLine( "Pass with Grade A");
                }
                else if (Perc >= 60)
                {
                    Console.WriteLine("Pass with Grade B");
                }
                else if (Perc >= 40)
                {
                    Console.WriteLine("Pass with Grade C");
                }
            }
            
            
            return "Fail";
            

            
        }
    }
}
