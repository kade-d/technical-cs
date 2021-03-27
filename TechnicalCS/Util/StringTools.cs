using TechnicalCS;
using System;
using System.Text;

namespace TechnicalCS.TechDemos.Util
{

    public static class StringTools
    {

        public static string Repeat(this string input, int count)
        {
            if (!string.IsNullOrEmpty(input))
            {
                StringBuilder builder = new StringBuilder(input.Length * count);

                for (int i = 0; i < count; i++) builder.Append(input);

                return builder.ToString();
            }

            return string.Empty;
        }

        public static string RepeatFormat(this string input, int count, int[] arr)
        {
            if (!string.IsNullOrEmpty(input))
            {
                StringBuilder builder = new StringBuilder(input.Length * count);

                for (int i = 0; i < count; i++) builder.Append(string.Format(input, arr[i]));

                return builder.ToString();
            }

            return string.Empty;
        }

    }


}