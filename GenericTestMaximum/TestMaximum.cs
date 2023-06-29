using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTestMaximum
{
    public class TestMaximum
    {
        public int GetMaximumIntNumber()
        {
            Console.WriteLine("Enter First Number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int numThree = Convert.ToInt32(Console.ReadLine());
            if (numOne.CompareTo(numTwo) > 0 && numOne.CompareTo(numThree) > 0 ||
               numOne.CompareTo(numTwo) >= 0 && numOne.CompareTo(numThree) > 0 ||
               numOne.CompareTo(numTwo) > 0 && numOne.CompareTo(numThree) >= 0)
            {
                return numOne;
            }
            if (numTwo.CompareTo(numOne) > 0 && numTwo.CompareTo(numThree) > 0 ||
                numTwo.CompareTo(numOne) >= 0 && numTwo.CompareTo(numThree) > 0 ||
                numTwo.CompareTo(numOne) > 0 && numTwo.CompareTo(numThree) >= 0)
            {
                return numTwo;
            }
            if (numThree.CompareTo(numTwo) > 0 && numThree.CompareTo(numOne) > 0 ||
                numThree.CompareTo(numTwo) >= 0 && numThree.CompareTo(numOne) > 0 ||
                numThree.CompareTo(numTwo) > 0 && numThree.CompareTo(numOne) >= 0)
            {
                return numThree;
            }
            return numOne;

        }
        public float GetMaximumFloat()
        {
            Console.WriteLine("Enter First float number");
            float floatOne = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second float number");
            float floatTwo = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third floatnumber");
            float floatThree = float.Parse(Console.ReadLine());
            if (floatOne.CompareTo(floatTwo) > 0 && floatOne.CompareTo(floatThree) > 0 ||
               floatOne.CompareTo(floatTwo) >= 0 && floatOne.CompareTo(floatThree) > 0 ||
               floatOne.CompareTo(floatTwo) > 0 && floatOne.CompareTo(floatThree) >= 0)
            {
                return floatOne;
            }
            if (floatTwo.CompareTo(floatOne) > 0 && floatTwo.CompareTo(floatThree) > 0 ||
                floatTwo.CompareTo(floatOne) >= 0 && floatTwo.CompareTo(floatThree) > 0 ||
                floatTwo.CompareTo(floatOne) > 0 && floatTwo.CompareTo(floatThree) >= 0)
            {
                return floatTwo;
            }
            if (floatThree.CompareTo(floatTwo) > 0 && floatThree.CompareTo(floatOne) > 0 ||
                floatThree.CompareTo(floatTwo) >= 0 && floatThree.CompareTo(floatOne) > 0 ||
                floatThree.CompareTo(floatTwo) > 0 && floatThree.CompareTo(floatOne) >= 0)
            {
                return floatThree;
            }
            return floatOne;
        }
        public string GetMaximumString()
        {
            Console.WriteLine("Enter First string");
            string stringOne = Console.ReadLine();
            Console.WriteLine("Enter Second string");
            string stringTwo = Console.ReadLine();
            Console.WriteLine("Enter Third string");
            string stringThree = Console.ReadLine();
            if (stringOne.CompareTo(stringTwo) > 0 && stringOne.CompareTo(stringThree) > 0 ||
               stringOne.CompareTo(stringTwo) >= 0 && stringOne.CompareTo(stringThree) > 0 ||
               stringOne.CompareTo(stringTwo) > 0 && stringOne.CompareTo(stringThree) >= 0)
            {
                return stringOne;
            }
            if (stringTwo.CompareTo(stringOne) > 0 && stringTwo.CompareTo(stringThree) > 0 ||
                stringTwo.CompareTo(stringOne) >= 0 && stringTwo.CompareTo(stringThree) > 0 ||
                stringTwo.CompareTo(stringOne) > 0 && stringTwo.CompareTo(stringThree) >= 0)
            {
                return stringTwo;
            }
            if (stringThree.CompareTo(stringTwo) > 0 && stringThree.CompareTo(stringOne) > 0 ||
                stringThree.CompareTo(stringTwo) >= 0 && stringThree.CompareTo(stringOne) > 0 ||
                stringThree.CompareTo(stringTwo) > 0 && stringThree.CompareTo(stringOne) >= 0)
            {
                return stringThree;
            }
            return stringOne;
        }
    }
}
