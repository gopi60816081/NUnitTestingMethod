using NumberSystem;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTest
{
    [TestFixture]
    public  class Class2
    {
        [Test]
        public void Total()   {
            double t = 40;
            double e = 100;
            double M = 50;
            double S = 60;
            double SS = 50;
            double expected = 300;
            Student stu = new Student("RAMKUMAR", "Tenth", t, e, M, S, SS);
            double actual = stu.TotalMark();
            
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Percentage() 
        {
            double t = 40;
            double e = 100;
            double M = 50;
            double S = 60;
            double SS = 50;
           
            double expected = 60;
            Student stu = new Student("RAMKUMAR", "Tenth", t, e, M, S, SS);
            double actual = stu.Percentage();
            Assert.That(actual, Is.EqualTo(expected));
            
        }

        [Test]
        
        public void TestGrade()
        {
            // Arrange
            string expectedGrade = "Pass with Grade B";
            Student stu1 = new Student("RAMKUMAR","", 60, 60, 63, 50, 70); 
            int passMark = 40;

            // Act
            bool allSubjectsPassed = stu1.Tmark >= passMark && stu1.Emark >= passMark && stu1.Mmark >= passMark &&
                                      stu1.Smark >= passMark &&
                                      stu1.SSmark >= passMark;
            string actualGrade= stu1.Grade();

            if (allSubjectsPassed)
            {
                double totalMarks = stu1.Tmark + stu1.Emark + stu1.Mmark + stu1.Smark + stu1.SSmark;
                double percentage = (totalMarks / 500) * 100; 

                if (percentage >= 80)
                {
                    actualGrade = "Pass with Grade A";
                }
                else if (percentage >= 60)
                {
                    actualGrade = "Pass with Grade B";
                }
                else if (percentage >= 40)
                {
                    actualGrade = "Pass with Grade C";
                }
                else
                {
                    actualGrade = "Fail";
                }
            }
            else
            {
                actualGrade = "Fail";
            }

            // Assert
            Assert.That(actualGrade, Is.EqualTo(expectedGrade));
        }


    }
}
