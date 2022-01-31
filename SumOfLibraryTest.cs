using SumOfLibrary;
using System;
using Xunit;

namespace TestProject
{
    public class SumOfLibraryTest
    {
        [Theory]
        [InlineData(10, 23)]
        [InlineData(20, 63)]
        [InlineData(1, 0)]
        [InlineData(3, 0)]
        [InlineData(5, 3)]
        public void SumOfMultiple_Test(int limit,long expected)
        {
            ISumOfLibraryService sumOfLibrary = new SumOfLibraryService();
            Assert.Equal(expected, sumOfLibrary.Do(limit));
        }

        [Fact]
        public void SumOfMultiple_ExceptionTest()
        {
            ISumOfLibraryService sumOfLibrary = new SumOfLibraryService();
            Assert.Throws<Exception>(() => sumOfLibrary.Do(-3));
        }
    }
}
