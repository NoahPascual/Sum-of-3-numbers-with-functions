// Noah Pascual
// MIS 3013-995
// Participation 12.1 - Sum of 3 numbers with functions

// Instructions:

    //1. Call a method to display the header
    //2. Set a global variable (validate a number was entered)
    //3. Prompt the user to enter 3 different numbers(1 is a valid input and so is 5.5) and put them in a list
    //4. Call a method to add all 3 numbers together and output the result displaying 2 decimal places
    //5. Calculate a second value, where you multiply the sum of the 3 numbers by a the global variable
    //6. Compress and save the folder, and submit to Canvas

using System;
using System.Collections.Generic;    // To get List<> to work.
using System.Linq;                  // To get .Sum to work.


namespace Participation_12._1
{
    class Program
    {
        static double GlobalVariable;

        static void Main(string[] args)
        {
            DisplayHeader();
            Console.WriteLine("Please set a global variable");
            Program.GlobalVariable = ValidateNumber(Console.ReadLine());
            List<double> numbers = new List<double>();

            Console.WriteLine("Please enter a number >>>");
            numbers.Add(ValidateNumber(Console.ReadLine()));

            Console.WriteLine("\n\rPlease enter a number >>>");
            numbers.Add(ValidateNumber(Console.ReadLine()));

            Console.WriteLine("\n\rPlease enter a number >>>");
            numbers.Add(ValidateNumber(Console.ReadLine()));

            //double sum = Add(numbers);
            Console.WriteLine($"\n\rThose numbers added together equal {Add(numbers):N2}\n\r");
            Console.WriteLine($"Those numbers multiplied by the constant {GlobalVariable} is {(GlobalVariable * Add(numbers)):N2}");

            Console.ReadKey();
        }

        static double Add(List<double> numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        static double ValidateNumber(string input)
        {
            bool isNumber = false;
            double validNumber;
            do
            {
                isNumber = double.TryParse(input, out validNumber);

                if (!isNumber)
                {
                    Console.WriteLine("Please enter a valid number >>>");
                }
            } while (!isNumber);

            return validNumber;
        }

        static void DisplayHeader()
        {
            string title = "--- Participation 12.1 - Sum of 3 numbers with functions ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
        }
    }
}
