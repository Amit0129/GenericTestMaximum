using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTestMaximum
{
    public class TestMaximum<T> where T : IComparable
    {
        public T[] parameters;
        public TestMaximum(T[] parameters)
        {
            this.parameters = parameters;
        }
        public T[] Sort(T[] parameters)
        {
            Array.Sort(parameters);
            return parameters;
        }
        public T FindMaximum(T[] parameters)
        {
            var maxValue = Sort(parameters);
            return maxValue[maxValue.Length - 1];
        }
        public T GetMaxValue()
        {
            var maximumValue = FindMaximum(parameters);
            return maximumValue;
        }
        public void ToPrint()
        {
            var maximum = FindMaximum(this.parameters);
            Console.WriteLine($"The Maximum value is {maximum}");

        }
    }
}
