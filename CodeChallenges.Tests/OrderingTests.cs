using CodeChallenges.Domain.Logic;
using System;
using Xunit;

namespace CodeChallenges.Tests
{
    public class OrderingTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1021, 2110)]
        [InlineData(123456789, 987654321)]
        [InlineData(15, 51)]
        public void ShouldOrderNumberContentDescending(uint inputNumber, int expectedNumber)
        {   
            var processedResult = (new Ordering()).OrderByDescending(inputNumber);

            Assert.Equal(expectedNumber, processedResult);
        }
    }
}
