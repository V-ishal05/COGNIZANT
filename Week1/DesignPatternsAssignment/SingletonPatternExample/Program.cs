using System;

namespace SingletonPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("Application Started");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("User Logged In");

            Console.WriteLine();

            if (logger1 == logger2)
            {
                Console.WriteLine("Only one Logger instance exists.");
            }
            else
            {
                Console.WriteLine("Multiple Logger instances exist.");
            }

            Console.ReadKey();
        }
    }
}