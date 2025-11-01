using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static Calculations.Insurance;

namespace Calculations.Test
{
    [Collection("Insurance")]
    public class InsuranceTest(InsuranceCollectionFixture insuranceCollectionFixture)
    {

        [Fact]
        public void DiscountPercentage_GivenAgeOlderThen18_DiscountBetween5And20()
        {
            // Arrange
            var insurance = insuranceCollectionFixture.insurance;

            // Act
            var discount = insurance.DiscountPercentage(70);

            // Assert
            Assert.InRange(discount, 5, 20);
        }

        [Fact]
        public void DiscountPercentage_GivenAgeBelow25_DiscountIs5()
        {
            // Arrange
            var insurance = insuranceCollectionFixture.insurance;

            // Act
            var discount = insurance.DiscountPercentage(24);

            // Assert
            Assert.Equal(5, discount);
        }

        [Fact]
        public void DiscountPecentage_GivenAgeBelow18_ThrowsInvalidDataContractException()
        {
            // Arrange
            var insurance = insuranceCollectionFixture.insurance;

            // Act & Assert
            Assert.Throws<InvalidDataContractException>(() => insurance.DiscountPercentage(17));
        }

        [Fact]
        public void Customer_YearsLessThan5_ReturnsCustomer()
        {
            //Arrange
            var customer = CustomerFactory.GetInstance(10, 20);

            //Assert 
            Assert.IsType<LoyalCustomer>(customer);
            Assert.IsType<Customer>(customer, false);
        }
    }
}
