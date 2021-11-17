using System;

namespace ConsoleApp1 //group project together
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string[] stringArray = { "lol", "what", "this", "works", "I", "Guess" };
            int stringArrayLength = stringArray.Length;

            //output to user
            myPrintFunct(stringArray, stringArrayLength);
            Console.WriteLine("What's your line?: ");
            string myLine = Console.ReadLine();
            Console.WriteLine($"Your line is {myLine}");
        }

        //function to print array
        static void myPrintFunct(string[] stringArray, int stringArrayLength)
        {
            //loop through array printing each item
            for (int i = 0; i < stringArrayLength; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }
    }
}  