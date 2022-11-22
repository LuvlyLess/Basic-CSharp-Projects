using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // structs
            Numbers numbers = new Numbers();
            Numbers numbers1 = numbers;
            numbers1.Amount = (decimal)12.99;
            
            Console.WriteLine(" My struck decimal Amount " + numbers1.Amount);
            Console.ReadLine();
           // var number2 = (Numbers)Enum.Parse(typeof(Numbers), numbers.ToString());

        }
        
    }
}
