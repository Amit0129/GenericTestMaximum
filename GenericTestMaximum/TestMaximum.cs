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
            Console.WriteLine("Eneter First Number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eneter Second Number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eneter Third Number");
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
            Console.WriteLine("Eneter First floatber");
            float floatOne = float.Parse(Console.ReadLine());
            Console.WriteLine("Eneter Second floatber");
            float floatTwo = float.Parse(Console.ReadLine());
            Console.WriteLine("Eneter Third floatber");
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
    }
}
