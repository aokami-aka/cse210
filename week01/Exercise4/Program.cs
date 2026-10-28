using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int isFinished = 1;

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (isFinished != 0)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                isFinished = 0;
            }
            else
            {
                numbers.Add(number);
            }
        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            Console.WriteLine($"The sum is: {sum}");

            double average = numbers.Average();
            Console.WriteLine($"The average is: {average}");

            int largest = numbers.Max();
            Console.WriteLine($"The largest number is: {largest}");

            List<int> positiveNumbers = numbers
                .Where(n => n > 0)
                .ToList();

            if (positiveNumbers.Count > 0)
            {
                int smallestPositive = positiveNumbers.Min();
                Console.WriteLine(
                    $"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers.");
            }

            // Sort the numbers in ascending order
            numbers.Sort();

            Console.WriteLine("The sorted list is:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}