using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTime_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current DateTime is \n"); 
            Console.WriteLine(DateTime.Now);// Writing the current datetime to the console using DateTime.Now
            

            Console.WriteLine("Please enter a Number...\n"); // asking for user input
            int UserInput = Convert.ToInt32(Console.ReadLine()); // converting to int



            DateTime dateTime = DateTime.Now; // creating a instance of current datetime
           
            Console.WriteLine(dateTime.AddHours(UserInput)); // adding user input in hours to the current date time
            
            Console.ReadLine();
        }
    }
}
