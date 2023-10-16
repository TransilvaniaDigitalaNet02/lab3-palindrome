namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Text:");
            string text = Console.ReadLine() ?? string.Empty;

            bool isPalindrome = StringHelper.IsPalindrome(text);
            Console.WriteLine($"Is palindrome: {isPalindrome}");
        }
    }
}