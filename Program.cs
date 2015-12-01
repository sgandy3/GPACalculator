using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpacalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates a student’s GPA on a 4.0 scale. Take user input.

            //get number of classes taken
            Console.WriteLine("How many Classes Have You Taken?");
            int classAmt = Convert.ToInt32(Console.ReadLine()); //number

            //get letter grades from each class
            Console.WriteLine("How many A's do you have?");
            double GradeA = Convert.ToInt32(Console.ReadLine()); //from string to int

            //multiply
            GradeA = GradeA * 4.0;


            //get letter grades from each class
            Console.WriteLine("How many B's do you have?");
            double GradeB = Convert.ToInt32(Console.ReadLine()); //from string to int

            //multiply
            GradeB = GradeB * 3.0;

            //get letter grades from each class
            Console.WriteLine("How many C's do you have?");
            double GradeC = Convert.ToInt32(Console.ReadLine()); //from string to int

            //multiply
            GradeC = GradeC * 2.0;

            //get letter grades from each class
            Console.WriteLine("How many D's do you have?");
            double GradeD = Convert.ToInt32(Console.ReadLine()); //from string to int

            //multiply
            GradeD = GradeD * 1.0;

            //get letter grades from each class
            Console.WriteLine("How many F's do you have?");
            double GradeF = Convert.ToInt32(Console.ReadLine()); //from string to int

            //multiply
            GradeF = GradeF * 0.0;


            //sum letters
            double gradeSum = GradeA + GradeB + GradeC + GradeD + GradeF;


            //figure average (sum of all letters / number of classes
            double gpa = gradeSum / classAmt;

            Console.WriteLine("Your GPA is " + gpa);
            
          

           

            
        }
    }
}
