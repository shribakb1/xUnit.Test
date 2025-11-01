using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Calculations.Test
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullName_GivenEmptyFirstName_ResultMatchesFluentCheks()
        {
            // Arrange
            var names = new Names();

            // Act
            var fullName = names.MakeFullName("John", "Doe");

            // Assert
            fullName.Should().NotBeNullOrEmpty()
                .And.StartWith("John")
                .And.EndWith("Doe")
                .And.MatchRegex("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+")
                .And.BeOfType<string>();
        }

        [Fact]
        public void MakeFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            // Arrange
            var names = new Names();
            var firstName = "John";
            var lastName = "Doe";

            // Act
            var result = names.MakeFullName(firstName, lastName);

            // Assert
            Assert.Equal("John Doe", result);
        }

        [Fact]
        public void MakeFullName_GivenFirstAndLastName_FirstNameExists()
        {
            // Arrange
            var names = new Names();

            // Act
            var fullName = names.MakeFullName("John", "Doe");

            // Assert
            Assert.Contains("John", fullName, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void MakeFullName_GivenFirstAndLastName_MathesRegex()
        {
            // Arrange
            var names = new Names();

            // Act
            var fullName = names.MakeFullName("John", "Doe");

            // Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]", fullName);
        }

        [Fact]
        public void MakeFullName_GivenMethodNotCalled_NickNameMustBeNull()
        {
            // Arrange
            var names = new Names();

            // Act
            // No method call

            // Assert
            Assert.Null(names.NickName);
        }
    }
}
