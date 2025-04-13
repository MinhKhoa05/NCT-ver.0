using System;
using System.Text;

namespace GUI.Helpers
{
    public static class StringHelper
    {
        public static string FormatProperName(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var words = input.Trim().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();

            foreach (var word in words)
            {
                if (word.Length == 1)
                {
                    sb.Append(char.ToUpper(word[0])).Append(' ');
                }
                else
                {
                    sb.Append(char.ToUpper(word[0])).Append(word.Substring(1)).Append(' ');
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}