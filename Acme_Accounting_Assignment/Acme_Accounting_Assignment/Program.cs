using System;


namespace CSharp_Assignments
{
    internal class Program
    {
        static void Main()
        {
            string Welcome = "Hello ";
            string Acme = "Welcome to Acme Accounting Systems\n \nRemember, we’re “accounting” on you! \n";
            string accountNumber = "What's your Account Number";
            string AcmeAccNum = Welcome + accountNumber;
            Console.WriteLine(AcmeAccNum);
            string accNum = Console.ReadLine();
            Console.WriteLine(Acme + accNum);
            Console.ReadLine();
        }
    }
}

