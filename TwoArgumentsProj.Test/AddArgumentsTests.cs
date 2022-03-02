using NUnit.Framework;
using System;
using TwoArgumentsProj.Models;

namespace TwoArgumentsProj.Test
{
    public class AddArgumentsTests
    {
        private AddArguments addArguments = new();
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Test", "Hello", "TestHello" )]
        public void ShouldDecideWhetherConcatArgsReturnsRightResultForStrings(string arg1, string arg2, string expectedResult)
        {
            var result = addArguments.ConcatArgs(arg1, arg2);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase(2, 3, 5)]
        [TestCase(2, 5, 7)]
        public void ShouldDecideWhetherConcatArgsReturnsRightResultForInts(int arg1, int arg2, int expectedResult)
        {
            var result = addArguments.ConcatArgs(arg1, arg2);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase(true, true)]
        [TestCase(true, false)]
        public void ShouldDecideWhetherConcatArgsReturnsRightResultForBool(bool arg1, bool arg2)
        {
            Assert.Throws<ArgumentException>(() => addArguments.ConcatArgs(arg1, arg2));
        }

        [TestCase(2.5, 3.5, 6.0)]
        [TestCase(2.1, 5.5, 7.6)]
        public void ShouldDecideWhetherConcatArgsReturnsRightResultForDouble(double arg1, double arg2, double expectedResult)
        {
            var result = addArguments.ConcatArgs(arg1, arg2);
            Assert.IsTrue(result == expectedResult);
        }

    }
}