using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
using Xunit.v3;

namespace Calculations.Test
{
    public class AddDataAttribute : DataAttribute
    {
        public override ValueTask<IReadOnlyCollection<ITheoryDataRow>> GetData(MethodInfo testMethod, DisposalTracker disposalTracker)
        {

            return new ValueTask<IReadOnlyCollection<ITheoryDataRow>>(
            new List<ITheoryDataRow>
            {
                new TheoryDataRow(1.1m, 2.2m, 3.3m),
                new TheoryDataRow(-1.5m, -2.5m, -4.0m),
                new TheoryDataRow(0.1m, 0.2m, 0.3m),
                new TheoryDataRow(100.123m, 200.456m, 300.58m),
            });
        }

        public override bool SupportsDiscoveryEnumeration()
        {
            return true;
        }
    }
}
