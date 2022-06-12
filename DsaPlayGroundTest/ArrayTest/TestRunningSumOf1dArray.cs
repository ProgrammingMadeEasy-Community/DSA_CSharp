using DsaPlayGround.Array;
using Xunit;

namespace DsaPlayGroundTest.ArrayTest
{
    public class TestRunningSumOf1dArray
    {
        [Fact]
        public void ValidInput()
        {
            // Arrange
            var nums = new int[4] { 1, 2, 3, 4 };
            var expectedOutput = new int[4] { 1, 3, 6, 10 };

            // Act
            var actualOutput = RunningSumOf1dArray.RunningSum(nums);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
