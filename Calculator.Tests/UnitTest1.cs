using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            double a = 5.0;
            double b = 3.0;
            double expected = 8.0;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_PositiveAndNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            double a = 10.0;
            double b = -3.0;
            double expected = 7.0;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            double a = 10.0;
            double b = 4.0;
            double expected = 6.0;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtract_NegativeResult_ReturnsCorrectDifference()
        {
            // Arrange
            double a = 3.0;
            double b = 8.0;
            double expected = -5.0;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            double a = 6.0;
            double b = 7.0;
            double expected = 42.0;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Multiply_ByZero_ReturnsZero()
        {
            // Arrange
            double a = 15.0;
            double b = 0.0;
            double expected = 0.0;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Multiply_NegativeNumbers_ReturnsPositiveProduct()
        {
            // Arrange
            double a = -4.0;
            double b = -3.0;
            double expected = 12.0;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            double a = 15.0;
            double b = 3.0;
            double expected = 5.0;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_WithDecimalResult_ReturnsCorrectQuotient()
        {
            // Arrange
            double a = 10.0;
            double b = 3.0;
            double expected = 10.0 / 3.0;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result, 10);  // 10 decimal places precision
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            double a = 10.0;
            double b = 0.0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [Fact]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
            // Arrange
            double a = 0.0;
            double b = 5.0;
            double expected = 0.0;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}