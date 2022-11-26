using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try // using a try catch to catch exceptions
            {
                Console.WriteLine("Please enter you Age");
                int UserAge = Convert.ToInt32(Console.ReadLine());  // converting userinput
                var currentDate = DateTime.Now; // getting the current year to compare
                Console.WriteLine(UserAge - DateTime.Now.Year + " The year you were born"); // printing the year they were born
                
                if (UserAge < 0) // using
                {
                    throw new Exception("Negative Age is Not Possible"); // creating a simple exception message for user
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please use correct Format, Digits Only"); 
            }
            Console.ReadLine();
        }
    }
}
