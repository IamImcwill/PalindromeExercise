using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("racecar", true)]
        [InlineData ("hello", false)]
        [InlineData ("water", false)]
        [InlineData ("nuts", false)]
        [InlineData ("level", true)]
        [InlineData ("radar", true)]
        [InlineData ("kayak", true)]
        [InlineData ("Racecar", true)]
        public void IsAPalindrome_Test(string word, bool expected)
        {
            var ws = new WordSmith();

            var actual = ws.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
