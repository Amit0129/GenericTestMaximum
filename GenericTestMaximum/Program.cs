namespace GenericTestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestMaximum testMaximum = new TestMaximum();
            int maxNumber = testMaximum.GetMaximumIntNumber();
            Console.WriteLine($"The maxumum number between three integer is : {maxNumber}");
        }
    }
}