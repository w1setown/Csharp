using Xunit;
using AvanceretLommeregner;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestPlus()
        {
            // Arrange
            double expected = 5;

            // Act
            double result = Program.Plus(2, 3);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMinus()
        {
            // Arrange
            double expected = 2;

            // Act
            double result = Program.Minus(5, 3);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestGange()
        {
            // Arrange
            double expected = 6;

            // Act
            double result = Program.Gange(2, 3);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestDivider()
        {
            // Arrange
            double expected = 2;

            // Act
            double result = Program.Divider(6, 3);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestDividerByZero()
        {
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => Program.Divider(6, 0));
        }

        [Fact]
        public void TestProcent()
        {
            // Arrange
            double expected = 20;

            // Act
            double result = Program.Procent(200, 10);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestPotens()
        {
            // Arrange
            double expected = 8;

            // Act
            double result = Program.Potens(2, 3);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
