using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declerating variable in snake case
            int mark_math, mark_phy, mark_sc, mark_chem;
            decimal percentage;
            Console.WriteLine("Please enter the mark that you got in maths");
            mark_math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the mark that you got in physics");
            mark_phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the mark that you got in computer science");
            mark_sc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the mark that you got in Chemistry");
            mark_chem = Convert.ToInt32(Console.ReadLine());
            //introduce percentage as a average for grades
            percentage = (mark_math + mark_phy + mark_sc + mark_chem) / 4;
            Console.WriteLine("Your percentage is" + percentage);
            //Marks >= 80 – Grade A
            //Marks >= 70 and < 80 – Grade B
            //Marks >= 60 and < 70 – Grade C
            //Marks >= 50 and < 60 – Grade D
            //Marks < 50 – Grade F

            switch (percentage)
            {
                 case var s when (percentage >=80):
                    Console.WriteLine("Excellent! Your grade is A");
                    break;
                 case var s when (percentage <80 && percentage>=70):
                    Console.WriteLine("Good! Your grade is B");
                    break;
                 case var s when (percentage <70 && percentage>=60):
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;
                 case var s when (percentage <60 && percentage>=50):
                    Console.WriteLine("Pass. Your grade is D");
                    break;
                case var s when (percentage < 50):
                    Console.WriteLine("Fail. Your grade is F");
                    break;

            }
            Console.ReadKey();
            




        }
    }
}