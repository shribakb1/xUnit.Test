using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Internal;
using Xunit.Sdk;
using Xunit.v3;

namespace Calculations.Test
{
    public class TestCollectionOrderer : ITestCollectionOrderer
    {
        public IReadOnlyCollection<TTestCollection> OrderTestCollections<TTestCollection>(
            IReadOnlyCollection<TTestCollection> testCollections) where TTestCollection : ITestCollection
        {
            return testCollections.OrderBy(tc => tc.TestCollectionDisplayName).CastOrToReadOnlyCollection();
        }
    }
}
