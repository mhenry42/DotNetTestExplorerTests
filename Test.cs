using System;
using Xunit;
using Xunit.Abstractions;

namespace DotNetTestExplorerTests
{
    public class Test
    {
        [Theory]
        [InlineData(")")]
        public void ClosedParenthesisTest(string str)
        {
            Assert.True(Program.Test(str));
        }

        [Theory]
        [InlineData("{}[]Aa1")]
        public void NoParenthesisTest(string str)
        {
            Assert.True(Program.Test(str));
        }

        [Theory]
        [InlineData("(")]
        public void ErrorOpenParenthesisTest(string str)
        {
            Assert.True(Program.Test(str));
        }

        [Theory]
        [InlineData(")A")]
        public void ErrorClosedParenthesisWithChar(string str)
        {
            Assert.True(Program.Test(str));
        }
    }
}
