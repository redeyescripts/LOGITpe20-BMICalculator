using System;

namespace TestFeedBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Write program that asks the users about their test results and
            Console.WriteLine("What was your last test results?");
                string result = Console.ReadLine().ToUpper();
            switch (result)
            {
                case "A":
                    Console.WriteLine("1");
                    break;
                case "B":
                    Console.WriteLine("2");
                    break;
                case "C":
                    Console.WriteLine("3");
                    break;
                case "D":
                    Console.WriteLine("4");
                    break;
                default:
                    Console.WriteLine("Try better next time!");
                    break;

            }
    }   }

}
