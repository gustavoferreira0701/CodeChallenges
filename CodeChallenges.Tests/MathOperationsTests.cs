using CodeChallenges.Domain.Logic;
using Xunit;

namespace CodeChallenges.Tests
{
    public class MathOperationsTests
    {
        [Theory]
        [InlineData(155, -1)]
        [InlineData(121, 144)]
        [InlineData(625, 676)]
        public void ShouldFindNextPerfectSquare(ulong number, int expectedResult)
        {
            var processedResult = new MathOperations().FindNextPerfectSquare(number);
            Assert.Equal(expectedResult, processedResult);
        }
    }
}
