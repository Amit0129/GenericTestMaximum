namespace GenericTestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Checking Max Interger number");
            Console.WriteLine("Enter 2 for Checking Max Float number");
            Console.WriteLine("Enter 3 for Checking Max String");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("How many number you want to compare");
                    int numbers = Convert.ToInt32(Console.ReadLine());
                    int[] noArr = new int[numbers];
                    for (int i = 0; i < numbers; i++)
                    {
                        Console.WriteLine("Enter a number");
                        int digit = Convert.ToInt32(Console.ReadLine());
                        noArr[i] = digit;
                    }
                    TestMaximum<int> testMaxInt = new TestMaximum<int>(noArr);
                    testMaxInt.ToPrint();
                    break;
                case 2:
                    Console.WriteLine("How many float number you want to compare");
                    int floatNumbers = Convert.ToInt32(Console.ReadLine());
                    float[] foArr = new float[floatNumbers];
                    for (int i = 0; i < floatNumbers; i++)
                    {
                        Console.WriteLine("Enter a number");
                        float fodigit = float.Parse(Console.ReadLine());
                        foArr[i] = fodigit;
                    }
                    TestMaximum<float> testMaxFloat = new TestMaximum<float>(foArr);
                    testMaxFloat.ToPrint();
                    break;
                case 3:
                    Console.WriteLine("How many string you want to compare");
                    int stringNumbers = Convert.ToInt32(Console.ReadLine());
                    string[] stArr = new string[stringNumbers];
                    for (int i = 0; i < stringNumbers; i++)
                    {
                        Console.WriteLine("Enter a number");
                        string letter = Console.ReadLine();
                        stArr[i] = letter;
                    }
                    TestMaximum<string> testMaxString = new TestMaximum<string>(stArr);
                    testMaxString.ToPrint();
                    break;
                default:
                    Console.WriteLine("Please Enter a valid choice");
                    break;
            }
        }
    }
}