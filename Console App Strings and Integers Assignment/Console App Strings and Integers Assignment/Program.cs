using System;
using System.Collections;
using System.Collections.Generic;

namespace Console_App_Strings_and_Integers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // try catch statement with exception catching 

            try
            {
                List<int> numbers = new List<int>() { 10, 15, 20 }; // My  list of integers

                Console.WriteLine("Please Pick a Number ");
                int UserInput = Convert.ToInt32(Console.ReadLine()); // User Number input parsed to convert to int

                


                for (int i = 0; i < numbers.Count; i++) // for loop 
                {
                    Console.WriteLine("My array List index numbers Divided by Your Number is \n" + numbers[i] / UserInput);
                }

            }
            catch (FormatException ex) // My catch format errors statements
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine("please don't divide by zero ");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of try catch statement"); //program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program
                Console.ReadLine();
            }











        }
        }
}
