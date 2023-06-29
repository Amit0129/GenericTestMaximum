namespace GenericTestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Checking Max Interger number");
            Console.WriteLine("Enter 2 for Checking Max Float number");
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
                    Console.WriteLine($"The maxumum number between three integer is : {maxFloat}");
                    break;
                default:
                    Console.WriteLine("Please Enter a valid choice");
                    break;
            }
        }
    }
}