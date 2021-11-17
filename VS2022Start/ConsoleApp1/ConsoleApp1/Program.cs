using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string[] stringArray = { "lol", "what", "this", "works", "I", "Guess" };
            int stringArrayLength = stringArray.Length;

            //output to user
            Console.WriteLine("Hello World!");
            Console.WriteLine(stringArrayLength);
            myPrintFunct(stringArray, stringArrayLength);

        }
        static void myPrintFunct(string[] stringArray, int stringArrayLength)
        {
            //logic
            for (int i = 0; i < stringArrayLength; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }
    }
}