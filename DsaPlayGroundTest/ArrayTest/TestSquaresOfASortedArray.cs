using DsaPlayGround.Array;
using Xunit;

namespace DsaPlayGroundTest.ArrayTest
{
    public class TestSquaresOfASortedArray
    {
        [Fact]
        public void ValidInput()
        {
            // Arrange
            var nums = new int[] { -4, -1, 0, 3, 10 };
            var expectedOutput = new int[] { 0, 1, 9, 16, 100 };

            // Act
            var actualOutput = SquaresOfASortedArray.SortedSquares(nums);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
