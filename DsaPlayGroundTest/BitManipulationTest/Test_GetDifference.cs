using System;
using Xunit;

namespace DsaPlayGroundTest.BitManipulationTest
{
    public class Test_GetDifference
    {
        [Fact]
        public void EmptyInput()
        {
            // Arrange
            int[] arr1 = { };
            int[] arr2 = { };
            var expectedOutput = 0;

            // Act
            var actualOutput = GetDifference.DifferenceOfTwoArrays(arr1, arr2);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void NullInput()
        {
            // Arrange
            int[] arr1 = null;
            int[] arr2 = null;
            var expectedOutput = 0;

            // Act
            var actualOutput = GetDifference.DifferenceOfTwoArrays(arr1, arr2);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void ValidInput()
        {
            // Arrange
            int[] arr1 = { 1, 2, 4 };
            int[] arr2 = { 1, 5, 2, 4 };
            var expectedOutput = 5;

            // Act
            var actualOutput = GetDifference.DifferenceOfTwoArrays(arr1,arr2);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

    }
}
