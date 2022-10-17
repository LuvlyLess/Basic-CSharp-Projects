using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison_Assignment_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Anonymous Income Comparison Program \n");

            string Person1 = "John Smith \n";

            int Person1Wage = 15 ;
            
            int Person1Hours = 40 ;
            
            string Person2 = "Jane Doe \n";

            int Person2Wage = 20 ;

            int Person2Hours = 40 ;

            int Person1Salary = 31200 ;

            int Person2Salary = 41600 ;


            Console.WriteLine(Person1 + " " + Person1Hours + " " + Person1Wage + " " + Person1Salary);
            Console.WriteLine(Person2 + " " +  Person2Hours + " " + Person2Wage + " " + Person2Salary);

            Console.WriteLine(Person1Salary > Person2Hours);


            Console.ReadLine();













        }
    }
}
