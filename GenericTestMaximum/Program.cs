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
            TestMaximum testMaximum = new TestMaximum();
            switch (choice)
            {
                case 1:
                    
                    int maxNumber = testMaximum.GetMaximumIntNumber();
                    Console.WriteLine($"The maxumum number between three integer is : {maxNumber}");
                    break;
                case 2:
                    float maxFloat = testMaximum.GetMaximumFloat();
                    Console.WriteLine($"The maxumum number between three float number is : {maxFloat}");
                    break;
                case 3:
                    string maxString = testMaximum.GetMaximumString();
                    Console.WriteLine($"The maxumum number between three string is : {maxString}");
                    break;
                default:
                    Console.WriteLine("Please Enter a valid choice");
                    break;
            }
        }
    }
}