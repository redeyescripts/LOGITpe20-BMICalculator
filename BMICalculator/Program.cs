using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is ypur name?");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());

            if (age <= 20)
            {
                Console.WriteLine("You are too young to use the calculator");
            }
            else if (age >= 60)
            {
                Console.WriteLine("You are too old to use the calculator");
            }
            else
            {
                Console.WriteLine("Enter your height (in meters): ");
                double Height = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter your weight: ");
                double Weight = Double.Parse(Console.ReadLine());
                double BMI = Weight / (Height * Height);

                if (BMI < 16)
                {
                    Console.WriteLine($"Your BMI scale is {BMI}, you are underweight.");
                }
                else if (BMI <= 24.9)
                {
                    Console.WriteLine($"Your BMI scale is {BMI}, you have an average body weight.");
                }
                else if (BMI <= 29.9)
                {
                    Console.WriteLine($"Your BMI scale is {BMI}, you are overweight.");
                }
                else
                {
                    Console.WriteLine($"Your BMI scale is {BMI}, you are obese.");
                }










            }

        }
    }
}
