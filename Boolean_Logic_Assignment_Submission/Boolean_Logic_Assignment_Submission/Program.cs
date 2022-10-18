using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                               Age statement 
            Console.WriteLine("Welcome to the Approval program \n please answer honestly \n Press Enter ");
            Console.WriteLine("What is your age \n ");
            int clientAge = Convert.ToInt32(Console.ReadLine());

            //                               DUI statement
            bool DUIStatus;
            Console.Write("Have You ever been charged with a DUI (True || False answer only)");
            DUIStatus = bool.Parse(Console.ReadLine());


            //                            Speeding ticket statment 
            Console.WriteLine("How many speeding tickets do you have? \n");
            string v = Console.ReadLine();
            int speedingTicket = Convert.ToInt16(v);

            
            if (clientAge >= 15 && DUIStatus == false && speedingTicket < 3)
            {
                Console.WriteLine(clientAge + " " + DUIStatus + " " + speedingTicket + " Your Approved ");
            }
            else
            {
                Console.WriteLine(" You're did not get Approved");
            }

            Console.ReadLine();






















        }  
    }
}
