using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int input;
            int sum = 0;
            double average = 0;

            Console.Write("Enter number: ");
            input = Convert.ToInt32(Console.ReadLine());

            while (input != 0)
            {
                if (input > 0)
                {
                    numbers.Add(input);
                }
                Console.Write("Enter number: ");
                input = Convert.ToInt32(Console.ReadLine());

            }

            foreach (int number in numbers)
            {
                sum += number;
            }

            average = sum / numbers.Count;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");

            EvenNumbers(numbers);
            DisplayAverage(numbers);
            Console.ReadLine();
        }

        static void EvenNumbers(List<int> ls)
        {
            Console.WriteLine("Even numbers\n");
            foreach (int num in ls)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void DisplayAverage(List<int> ls)
        {
            int sum = 0;
            int count = 0;
            double average = 0;
            
            foreach (int num in ls)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                    count++;
                }
                
            }
            average = sum / count;
            Console.WriteLine($"\nAverage: {average}");

        }
    }
}
