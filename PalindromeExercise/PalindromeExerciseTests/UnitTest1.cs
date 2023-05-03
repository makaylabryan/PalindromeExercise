using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("flowers", false)]
        [InlineData("civic", true)]
        [InlineData("civil", false)]
        [InlineData("redivider", true)]
        [InlineData("zoo", false)]
        public void Test1(string word, bool expected)
        {
            WordSmith testWord = new WordSmith();

            bool actual = testWord.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
