namespace Palindrome
{
    public static class StringHelper
    {
        public static bool IsPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            for (int indexStart = 0, indexEnd = text.Length - 1; indexStart < indexEnd; indexStart++, indexEnd--)
            {
                
                if (char.ToLowerInvariant(text[indexStart]) != char.ToLowerInvariant(text[indexEnd]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
