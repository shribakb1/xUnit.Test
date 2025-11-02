namespace Calculations.Test
{
    public class CalculatorTests
    {

        // Red -> Green -> Refactor

        [Fact]
        public void Add_GiventTwoInts_ReturnsSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
