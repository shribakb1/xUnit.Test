using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public decimal Add(decimal a, decimal b)
        {
            var sum = a + b;
            return Math.Round(sum, 2);
        }

        public IEnumerable<int> GetFibonacci(int length)
        {
            var first = 0;
            var second = 1;

            for (int i = 0; i < length; i++)
            {
                var next = first + second;

                first = second;
                second = next;

                yield return first;
            }
        }
    }
}
