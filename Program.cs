
using System;

namespace ArithmeticMean
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfRealNumbers = 10;
            double sumPositive = 0;
            int countPositive = 0;
            double sumNegative = 0;
            int countNegative = 0;

            Console.WriteLine("Enter 10 real numbers:");

            for (int i = 0; i < NumberOfRealNumbers; i++)
            {
                Console.Write($"Number {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    if (number > 0)
                    {
                        sumPositive += number;
                        countPositive++;
                    }
                    else if (number < 0)
                    {
                        sumNegative += number;
                        countNegative++;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid real number");
                    i--; 
                }
            }

            if (countPositive > 0)
            {
                double positiveMean = sumPositive / countPositive;
                Console.WriteLine($"Arithmetic mean of positive numbers: {positiveMean}");
            }
            else
            {
                Console.WriteLine("No positive numbers is enter");
            }

            if (countNegative > 0)
            {
                double negativeMean = sumNegative / countNegative;
                Console.WriteLine($"Arithmetic mean of negative numbers: {negativeMean}");
            }
            else
            {
                Console.WriteLine("No negative numbers is enter");
            }
        }
    }
}