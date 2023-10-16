using Palindrome;

namespace PalindromeTests
{
    public class StringHelperTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsPalindrome_WhenTextIsNullOrEmpty_ReturnsFalse(string text)
        {
            bool isPalindrome = StringHelper.IsPalindrome(text);
            Assert.False(isPalindrome);
        }

        [Theory]
        /* Palindromes */
        [InlineData("a", true)]
        [InlineData("aa", true)]
        [InlineData("ana", true)]
        [InlineData("Ana", true)]
        [InlineData("cojoc", true)]
        [InlineData("121", true)]
        [InlineData("1256521", true)]
        /* Not palindromes */
        [InlineData("test", false)]
        public void IsPalindrome_WhenTextSpecified_ReturnsExpectedResult(string text, bool expected)
        {
            bool isPalindrome = StringHelper.IsPalindrome(text);
            Assert.Equal(expected, isPalindrome);
        }
    }
}