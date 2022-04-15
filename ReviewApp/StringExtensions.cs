using System;
using System.Linq;
using System.Text;

namespace ReviewApp
{
    public static class StringExtensions
    {
        public static string ReverseHyphenatedLib(this string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return null;
            }

            return String.Join("-", value.ToCharArray().Reverse());
        }

        public static string ReverseHyphenatedManual(this string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return null;
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = value.Length - 1; i > 0; i--)
            {
                stringBuilder.Append(value[i] + "-");
            }

            return stringBuilder.Append(value[0]).ToString();
        }
    }
}
