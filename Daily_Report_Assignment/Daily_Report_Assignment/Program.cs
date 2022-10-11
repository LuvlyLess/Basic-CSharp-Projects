using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printing “Academy of Learning Career College” and “Student Daily Report”.

            Console.WriteLine("Welcome to the Academy of Learning Career College\nStudent Daily Report\n Press Enter to Continue \n");
            Console.ReadLine();


            // Requirment questions Input and Output
            string currentCourse;
            Console.WriteLine("\n What AOLCC course are you in?:");
            currentCourse = Console.ReadLine();
            

            Console.WriteLine("\n What Page Number: \n ");
            int pageNum = Convert.ToInt32(Console.ReadLine());
         
            //Boolean string Students request for help 




            string userInput;
            Console.WriteLine("Do you need help with anything ? Please answer true or false \n");
            userInput = Console.ReadLine();
          
            bool userInputBoolean = Convert.ToBoolean(userInput);
           

            bool helpNeeded = true;
            bool noHelpNeeded = false;

            Console.WriteLine(userInputBoolean ? "the student needs help \n" : "The student Does not need help \n");



            // Student experiences and feedback 
            
            Console.WriteLine("Were there any positive experiences you’d like to share ? Please give specifics. \n");
            string positiveExperience = Console.ReadLine();
            

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.\n");
            string additionalFeedBack = Console.ReadLine(); 
            



            // Hours studied - Using CSharp Convert datatype
            Console.WriteLine("How many hours did you study today? \n");
            int hours = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(string.Concat(currentCourse + pageNum + positiveExperience + additionalFeedBack + hours));  
            Console.WriteLine(" Your answers have been sent to an instructor \n");
            Console.WriteLine("\n Thank you for your answers. \n An Instructor will respond shortly.\n  Have a great day!");
        }
    }
}
