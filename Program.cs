using System;
using static Calculator;

namespace Calculator_CS
{
    class Program
    {
        static void Main()
        {
            float sum = GetNumber();

            while (true)
            {
                string mathOperator = GetMathOperator();

                if (mathOperator is "=")
                    break;

                float number = GetNumber();

                sum = mathOperator switch
                {
                    "+" => Addition(sum, number),
                    "-" => Subtraction(sum, number),
                    "/" => Division(sum, number),
                    "*" => Multiplication(sum, number),
                    _ => throw new ArgumentException($"Invalid operator: {mathOperator}"
                )};
            }

            Console.WriteLine(sum);
        }

        private static float GetNumber()
        {
            Console.WriteLine("Number: ");
            string input = Console.ReadLine();

            try
            {
                float n = float.Parse(input);
                return n;
            }

            catch
            {
                Console.WriteLine($"Invalid input: '{input}' is not a number.");
                throw;
            }
        }

        private static string GetMathOperator()
        {
            Console.WriteLine("Operator (+ - / * =): ");
            string mathOperator = Console.ReadLine();
            return mathOperator;
        }
    }
}