﻿namespace GenericTestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Checking Max Interger number");
            Console.WriteLine("Enter 2 for Checking Max Float number");
            Console.WriteLine("Enter 3 for Checking Max String");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            TestMaximum testMaximum = new TestMaximum();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter First Number");
                    int numOne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int numTwo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Third Number");
                    int numThree = Convert.ToInt32(Console.ReadLine());
                    int maxNumber = testMaximum.GetMaximun<int>(numOne, numTwo, numThree);
                    Console.WriteLine($"The maxumum number between three integer is : {maxNumber}");
                    break;
                case 2:
                    Console.WriteLine("Enter First float number");
                    float floatOne = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second float number");
                    float floatTwo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Third floatnumber");
                    float floatThree = float.Parse(Console.ReadLine());
                    float maxFloat = testMaximum.GetMaximun<float>(floatOne, floatTwo, floatThree);
                    Console.WriteLine($"The maxumum number between three float number is : {maxFloat}");
                    break;
                case 3:
                    Console.WriteLine("Enter First string");
                    string stringOne = Console.ReadLine();
                    Console.WriteLine("Enter Second string");
                    string stringTwo = Console.ReadLine();
                    Console.WriteLine("Enter Third string");
                    string stringThree = Console.ReadLine();
                    string maxString = testMaximum.GetMaximun<string>(stringOne, stringTwo, stringThree);
                    Console.WriteLine($"The maxumum between three string is : {maxString}");
                    break;
                default:
                    Console.WriteLine("Please Enter a valid choice");
                    break;
            }
        }
    }
}