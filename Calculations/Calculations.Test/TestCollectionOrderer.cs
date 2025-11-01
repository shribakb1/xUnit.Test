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
            //return testCollections.OrderBy(tc => tc.TestCollectionDisplayName).CastOrToReadOnlyCollection();

            return testCollections.OrderBy(tc =>
            {
                Console.WriteLine("Test Ordering...");
                tc.Traits.TryGetValue("Category", out var categoryValues);

                if (categoryValues != null && categoryValues.Any())
                {
                    return categoryValues.FirstOrDefault() ?? "";
                }
                else
                {
                    return tc.TestCollectionDisplayName;
                }
            }).CastOrToReadOnlyCollection();
        }
    }
}
