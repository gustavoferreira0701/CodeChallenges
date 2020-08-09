using CodeChallenges.Domain.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodeChallenges.Tests
{
    public class SearchingTests
    {

        [Theory]
        [InlineData(new[] { -1, 2, 100, 99 }, -1)]
        public void SearchTheLowestNumberFromArray(int[] entries, int expectedResult)
        {
            var processedResult = new Searching().SearchLowerNumber(entries);
            Assert.Equal(expectedResult, processedResult);
        }

        [Theory]
        [InlineData("test", "es")]
        [InlineData("testing", "t")]
        [InlineData("middle", "dd")]
        public void ShouldFindMiddleCharacterOnText(string inputText, string expectedResult)
        {
            var processedResult = new Searching().FindMiddleCharacter(inputText);
            Assert.Equal(expectedResult, processedResult);
        }
    }
}
