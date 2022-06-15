using DsaPlayGround.Array;
using Xunit;

namespace DsaPlayGroundTest.ArrayTest
{
    public class TestCheckOnesSegment_220615_PatZino
    {
        [Fact]
        public void ValidInput()
        {
            // Arrange
            var input = "110";
            var expectedOutput = true;

            // Act
            var actualOutput = CheckOnesSegment_220615_PatZino.CheckOnesSegment(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void InValidInput()
        {
            // Arrange
            var input = "1101";
            var expectedOutput = false;

            // Act
            var actualOutput = CheckOnesSegment_220615_PatZino.CheckOnesSegment(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
