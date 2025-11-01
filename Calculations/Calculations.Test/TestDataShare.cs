using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Test
{
    public static class TestDataShare
    {
        public static IEnumerable<object?[]> GetDecimalAddTestData()
        {
            yield return new object?[] { 1.1m, 2.2m, 3.3m };
            yield return new object?[] { -1.5m, -2.5m, -4.0m };
            yield return new object?[] { 0.1m, 0.2m, 0.3m };
            yield return new object?[] { 100.123m, 200.456m, 300.58m };
        }   
    }
}
