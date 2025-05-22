using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        float sum = 0;
        int Higher = -1;
        int number = -1;
        int lenght = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            sum += number;
            lenght++;
            if (number > Higher)
            {
                Higher = number;
            }
        }
        float average = sum / (lenght-1);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {Higher}");

    }
}