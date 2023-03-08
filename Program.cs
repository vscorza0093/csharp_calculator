using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {   
            Multiplication();
        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value:");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue + secondValue;

            Console.WriteLine($"Sum result: {result}");
            Console.ReadKey();
        }
        static void Subtract()
        {
            Console.Clear();

            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value:");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue - secondValue;

            Console.WriteLine($"Subtraction result: {result}"); 
            Console.ReadKey();
        }
        static void Division()
        {
            Console.Clear();

            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Second Value:");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue / secondValue;

            Console.WriteLine($"Division result: {result}");
            Console.ReadKey();
        }
        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue * secondValue;

            Console.WriteLine($"Multiplication result: {result}");
            Console.ReadKey();
        }
    }
}