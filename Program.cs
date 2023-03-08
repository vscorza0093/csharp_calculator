using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to simple csharp calculator");
            Menu();
        }

        static async void Menu()
        {
            Console.Clear();

            Console.WriteLine("What do you wish?\n");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Divide");
            Console.WriteLine("4 - Multiply");
            Console.WriteLine("Any other key to quit\n");
            Console.WriteLine("-----------\n");
            Console.WriteLine("Select an option:");
            char response = Console.ReadLine()[0];

            switch (response)
            {
                case '1': Sum(); break;
                case '2': Subtract(); break;
                case '3': Division(); break;
                case '4': Multiplication(); break;
                default: Console.WriteLine("Thank you for using (Enter to close the application)");
                        Console.ReadKey(); 
                        System.Environment.Exit(1); 
                        break;
            }
        }
        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Sum\n");
            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value:");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue + secondValue;

            Console.Write("\n");
            Console.WriteLine($"Sum result: {result}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Menu();
        }
        static void Subtract()
        {
            Console.Clear();

            Console.WriteLine("Subtract\n");
            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value:");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue - secondValue;

            Console.Write("\n");
            Console.WriteLine($"Subtraction result: {result}"); 
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Menu();
        }
        static void Division()
        {
            Console.Clear();

            Console.WriteLine("Division\n");
            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Second Value:");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue / secondValue;

            Console.Write("\n");
            Console.WriteLine($"Division result: {result}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Menu();
        }
        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Multiplication\n");
            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue * secondValue;

            Console.Write("\n");
            Console.WriteLine($"Multiplication result: {result}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Menu();
        }
    }
}