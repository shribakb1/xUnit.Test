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

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 3, 2)]
        public void Add_GivenTwoNumbers_ReturnsSum(int a, int b, int expected)
        {
            // Arrange
            var calculator = calcutorFixture.calculator;

            // Act
            var result = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }


        [Theory]
        [MemberData(nameof(TestDataShare.GetDecimalAddTestData), MemberType = typeof(TestDataShare))]
        public void Add_GivenTwoDecimalNumbers_ReturnsSum(decimal a, decimal b, decimal expected)
        {
            // Arrange
            var calculator = calcutorFixture.calculator;

            // Act
            var result = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(-1, false)]
        public void IsOdd_GivenNumber_ReturnsTrueOrFalse(int number, bool expected)
        {
            // Arrange
            var calculator = calcutorFixture.calculator;

            // Act
            var result = calculator.IsOdd(number);

            // Assert
            Assert.Equal(expected, result);
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
