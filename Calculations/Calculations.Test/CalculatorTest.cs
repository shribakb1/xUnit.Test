namespace Calculations.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_Givern1and2_Returns3()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(1, 2);

            // Assert
            Assert.Equal(3, result);  
        }

        [Fact]
        public void Add_GivenTwoDecimalValues_ReturnsRoundedSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(1.234m, 2.345m);

            // Assert
            Assert.Equal(3.58m, result);
        }
    }
}
