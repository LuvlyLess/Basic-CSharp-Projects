using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Input_Assignment
{
    public class Program
    {
        static void Main(string[] args) // learning file/io
        {
            Console.WriteLine("Please enter a number to be logged into the file"); // using console.writeline to ask for users input
            

            string write2Filetext = Convert.ToString(Console.ReadLine()); // converting user input to string
            File.WriteAllText(@"C:\Users\Leslie\Desktop\My Portfolio WebSite\Logsforschool.txt", write2Filetext); // writing user input convert write@Filetext to  the txt file
            string ReadtxtFile = File.ReadAllText(@"C:\Users\Leslie\Desktop\My Portfolio WebSite\Logsforschool.txt"); // using File.ReadAll to read the txt file the user input has been stored to


            Console.WriteLine("Your Number Input is " + ReadtxtFile);// writing input to the console
            Console.ReadLine();
  
        }
    }
}
