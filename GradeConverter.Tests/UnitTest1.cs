using System;
using Xunit;
using GradeConverter;

namespace GradeConverter.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1ReturnsA()
        {
            String output = GradeConverter.ConvertToEuropean("12");
            Assert.Equal("A", output);
        }

        [Fact]
        public void Test2Returns12()
        {
            String output = GradeConverter.ConvertToDanish("A");
            Assert.Equal("12", output);
        }
    }
}
