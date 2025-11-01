using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Test
{
    [Collection("Insurance")]
    public class InsuranceDetailsTest
    {
        [Fact]
        public void Insurance_InterestRate()
        {
            // Arrange
            var insurance = new Insurance();

            // Assert
            Assert.Equal(10, insurance.InteresRate);
        }
        
    }
}
