using Projet_UAA6_Recap.Services;
using Projet_UAA6_Recap.BusinessExceptions;

namespace Projet_UAA6_Recap.Test
{
    public class MathServiceTests
    {
        // ========================================================================
        // TEST DE L'ADDITION
        // ========================================================================

        [Fact]
        public void Addition_WithPositiveIntegers_ReturnsSum()
        {
            // Arrange
            decimal nb1 = 5;
            decimal nb2 = 10;
            decimal expected = 15;

            // Act
            decimal actual = MathService.Addition(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Addition_WithNegativeIntegers_ReturnsNegativeSum()
        {
            // Arrange
            decimal nb1 = -5;
            decimal nb2 = -10;
            decimal expected = -15;

            // Act
            decimal actual = MathService.Addition(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1.2, 2.3, 3.5)]
        [InlineData(-1.5, -2.2, -3.7)]
        [InlineData(10.5, -5.2, 5.3)]
        [InlineData(1.111, 2.222, 3.33)]
        [InlineData(5.555, 1.123, 6.68)]
        [InlineData(3.15131584, 0.4534542, 3.60)]
        public void Addition_WithReals_ReturnsSumRoundedSimple(decimal nb1, decimal nb2, decimal expected)
        {
            // Arrange (Données fournies par InlineData)

            // Act
            decimal actual = MathService.Addition(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1.11, 0.005, 1.12)]
        [InlineData(1.22, 0.005, 1.23)]
        [InlineData(-1.11, -0.005, -1.12)]
        [InlineData(-1.22, -0.005, -1.23)]
        public void Addition_WithMidpointRounding_ReturnsSumRoundedAwayFromZero(decimal nb1, decimal nb2, decimal expected)
        {
            // Arrange

            // Act
            decimal actual = MathService.Addition(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        // ========================================================================
        // TEST DE LA SOUSTRACTION
        // ========================================================================

        [Theory]
        [InlineData(10, 4, 6)]
        [InlineData(-10, -5, -5)]
        [InlineData(5, 10, -5)]
        public void Soustraction_WithIntegers_ReturnsDifference(decimal nb1, decimal nb2, decimal expected)
        {
            // Arrange

            // Act
            decimal actual = MathService.Soustraction(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5.5, 1.2, 4.3)]
        [InlineData(1.1, 2.2, -1.1)]
        public void Soustraction_WithReals_ReturnsDifferenceRoundedSimple(decimal nb1, decimal nb2, decimal expected)
        {
            // Arrange

            // Act
            decimal actual = MathService.Soustraction(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5.555, 1.11, 4.45)]
        [InlineData(-2.225, 0, -2.23)]
        public void Soustraction_WithMidpointRounding_ReturnsDifferenceRoundedAwayFromZero(decimal nb1, decimal nb2, decimal expected)
        {
            // Arrange

            // Act
            decimal actual = MathService.Soustraction(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        // ========================================================================
        // TEST DE LA MULTIPLICATION
        // ========================================================================

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-2, 3, -6)]
        [InlineData(-2, -3, 6)]
        public void Multiplication_WithIntegers_ReturnsProduct(decimal nb1, decimal nb2, decimal expected)
        {
            // Arrange

            // Act
            decimal actual = MathService.Multiplication(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2.5, 2.5, 6.25)]
        [InlineData(1.5, -2.0, -3.0)]
        public void Multiplication_WithReals_ReturnsProductRoundedSimple(decimal nb1, decimal nb2, decimal expected)
        {
            // Arrange

            // Act
            decimal actual = MathService.Multiplication(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2.11, 3.5, 7.39)]
        [InlineData(-2.11, 3.5, -7.39)]
        public void Multiplication_WithMidpointRounding_ReturnsProductRoundedAwayFromZero(decimal nb1, decimal nb2, decimal expected)
        {
            // Arrange

            // Act
            decimal actual = MathService.Multiplication(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        // ========================================================================
        // TEST DE LA DIVISION
        // ========================================================================

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(-10, 2, -5)]
        [InlineData(-10, -2, 5)]
        public void Division_WithIntegers_ReturnsQuotient(decimal nb1, decimal nb2, decimal expected)
        {
            // Arrange

            // Act
            decimal actual = MathService.Division(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 3, 3.33)]
        [InlineData(1, 8, 0.13)]
        public void Division_WithReals_ReturnsQuotientRoundedSimple(decimal nb1, decimal nb2, decimal expected)
        {
            // Arrange

            // Act
            decimal actual = MathService.Division(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2.47, 2.0, 1.24)]
        [InlineData(-2.47, 2.0, -1.24)]
        public void Division_WithMidpointRounding_ReturnsQuotientRoundedAwayFromZero(decimal nb1, decimal nb2, decimal expected)
        {
            // Arrange

            // Act
            decimal actual = MathService.Division(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Division_ByZero_ThrowsMathDivisionByZeroException()
        {
            // Arrange
            decimal nb1 = 42;
            decimal nb2 = 0;
            string expectedMessage = "Math Exception : Division par zéro";

            // Act
            var exception = Assert.Throws<MathDivisionByZeroException>(() => MathService.Division(nb1, nb2));

            // Assert
            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}