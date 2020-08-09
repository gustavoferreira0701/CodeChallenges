using CodeChallenges.Domain.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodeChallenges.Tests
{
    public class CounteringTests
    {
        [Theory]
        [InlineData("abba", 2)]
        [InlineData("abracadabra", 5)]
        public void ShouldCountNumberOfVowelsFromAString(string text, int expectedResult)
        {
            var processedResult = new Counter().VowelCounter(text);
            Assert.Equal(expectedResult, processedResult);
        }

    }
}
