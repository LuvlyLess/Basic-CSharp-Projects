using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_Assignments_Math_AND_Compairson_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //                                       input from the user, multiplies it by 50, and prints the result

            Console.WriteLine("Please Pick a Number");
            int userNumber = int.Parse(Console.ReadLine());            
            Console.WriteLine("Your Number Times fifty is " + userNumber * 50);
            Console.ReadLine();



            //                                      input from the user, adds 25 to it, and prints the result  

            Console.WriteLine("Please Pick a Number");
            int userNumberADD = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Number Plus TwentyFive is " + userNumberADD + 25);
            Console.ReadLine();


            //                                      input from the user, divides it by 12.5, and prints the result



            Console.WriteLine("Please Pick a Number");
            double userNumberDIVIDE = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Number Divided by 12.5 is " + userNumberDIVIDE / 12.5);
            Console.ReadLine();


            //                                        Input from the user, checks if it is greater than 50, and prints the true/false

            Console.WriteLine("Please Pick a Number");
            int userNumberGreater = int.Parse(Console.ReadLine());
            Console.WriteLine("Is Your Number Greater Than 50 ");
            Console.WriteLine(userNumberGreater > 50);
            Console.ReadLine();

            //                                      input from the user, divides it by 7, and prints the remainder

            Console.WriteLine("Please Pick a Number");
            double userNumberModulus = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Number is " + userNumberModulus % 7);
            Console.ReadLine();


        }
    }
}
