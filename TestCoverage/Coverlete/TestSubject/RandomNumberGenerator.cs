using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSubject
{
    public class RandomNumberGenerator
    {
        private readonly Random _random;

        public RandomNumberGenerator()
        {
            _random = new Random();
        }   

        public int GenerateNumber(int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentException("min should be less than or equal to max");
            }

            return _random.Next(min, max + 1);
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public int GenerateMultipleNumbers(int count, int min, int max)
        {
            if (count <= 0)
            {
                throw new ArgumentException("Count must be positive");
            }

            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += GenerateNumber(min, max);
            }
            return sum;
        }
    }
}
