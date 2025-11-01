using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Test
{
    [CollectionDefinition("Insurance")]
    [Trait("Category", "Insurance")]
    public class InsuranceCollectionDefinition : ICollectionFixture<InsuranceCollectionFixture>
    {
    }
}
