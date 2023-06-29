using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTestMaximum
{
    public class TestMaximum
    {
        public T GetMaximun<T>(T valueOne, T valueTwo, T valueThree) where T : IComparable
        {
            
            if (valueOne.CompareTo(valueTwo) > 0 && valueOne.CompareTo(valueThree) > 0 ||
               valueOne.CompareTo(valueTwo) >= 0 && valueOne.CompareTo(valueThree) > 0 ||
               valueOne.CompareTo(valueTwo) > 0 && valueOne.CompareTo(valueThree) >= 0)
            {
                return valueOne;
            }
            if (valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) > 0 ||
                valueTwo.CompareTo(valueOne) >= 0 && valueTwo.CompareTo(valueThree) > 0 ||
                valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) >= 0)
            {
                return valueTwo;
            }
            if (valueThree.CompareTo(valueTwo) > 0 && valueThree.CompareTo(valueOne) > 0 ||
                valueThree.CompareTo(valueTwo) >= 0 && valueThree.CompareTo(valueOne) > 0 ||
                valueThree.CompareTo(valueTwo) > 0 && valueThree.CompareTo(valueOne) >= 0)
            {
                return valueThree;
            }
            return valueOne;

        }

    }
}
