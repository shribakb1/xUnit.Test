using Xunit.v3;

namespace Calculations.Test
{
    public class CalculatorFixture
    {
         public Calculator calculator => new Calculator();
    }
    public class CalculatorTest(ITestOutputHelper testOutputHelper, CalculatorFixture calcutorFixture)
        : IClassFixture<CalculatorFixture>   
    {
        [Fact]
        [Trait("Category", "Calculator")]
        public void Add_Givern1and2_Returns3()
        {
            // Arrange
            var calculator = calcutorFixture.calculator;

            // Act
            var result = calculator.Add(1, 2);

            // Assert
            Assert.Equal(3, result);
            testOutputHelper.WriteLine("Test Executed");
        }

        [Fact]
        [Trait("Category", "Calculator")]
        public void Add_GivenTwoDecimalValues_ReturnsRoundedSum()
        {
            // Arrange
            var calculator = calcutorFixture.calculator;

            // Act
            var result = calculator.Add(1.234m, 2.345m);

            // Assert
            Assert.Equal(3.58m, result);
        }


        [Fact]
        [Trait("Category", "Fibonacci")]
        public void GetFibonacci_DoesNotIncludeZero()
        {
            // Arrange
            var calculator = calcutorFixture.calculator;

            // Act
            var fibo = calculator.GetFibonacci(5);

            // Assert
            Assert.All(fibo, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibonacci")]
        public void GetFibonacci_DoesNotInclude4()
        {
            // Arrange
            var calculator = calcutorFixture.calculator;

            // Act
            var fibo = calculator.GetFibonacci(5);

            // Assert
            Assert.DoesNotContain(4, fibo);
        }

        [Fact]
        [Trait("Category", "Fibonacci")]
        public void GetFibonacci_Include5()
        {
            // Arrange
            var calculator = calcutorFixture.calculator;

            // Act
            var fibo = calculator.GetFibonacci(5);

            // Assert
            Assert.Contains(5, fibo);
        }

        [Fact]
        [Trait("Category", "Fibonacci")]
        public void GetFibonacci_First5MembersAreCorrect()
        {
            // Arrange
            var calculator = calcutorFixture.calculator;
            var expected = new List<int> { 1, 1, 2, 3, 5 };

            // Act
            var fibo = calculator.GetFibonacci(5);

            // Assert
            Assert.Equal(expected, fibo);
        }
    }
}
