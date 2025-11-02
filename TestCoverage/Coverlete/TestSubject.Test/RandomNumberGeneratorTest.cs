namespace TestSubject.Test
{
    public class RandomNumberGeneratorTest
    {
        [Fact]
        public void IsNumberEven_GivenEvenNumber_ReturnsTrue()
        {
            // Arrange
            var rng = new RandomNumberGenerator();

            // Act
            var result = rng.IsNumberEven(4);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNumberEven_GivenOddNumber_ReturnsFalse()
        {
            // Arrange
            var rng = new RandomNumberGenerator();

            // Act
            var result = rng.IsNumberEven(-1);

            // Assert
            Assert.False(result);
        }
    }
}
