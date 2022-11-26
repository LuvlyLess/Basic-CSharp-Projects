using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            const string ConsoleName = "Console: HelloWorld"; // creating a const for a greeting
            Console.WriteLine("Welcome to {0}. Whats Your Name ?", ConsoleName); // printing the const greeting and asking name
            var UserName = Console.ReadLine(); // creating a variable using var




            // instantiating constructor
            var objOne = new SampleClass(10); // calling objs
            var obj2 = new SampleClass(firstname:"Tim");
            var obj3 = new SampleClass(10, firstname: "Monkey");

            
        }
    }
}
