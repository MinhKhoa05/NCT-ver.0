using System.Windows.Forms;
using System;
using System.Text;

namespace GUI.Helpers
{
    public static class FormHelper
    {  
        public static void OnlyAllowDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public static int TryParseInt(string text)
        {
            int.TryParse(text.Replace(",", ""), out int result);
            return result;
        }

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