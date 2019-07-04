using System;
using System.Text;

namespace XamarinSample
{
    public static class TranslatorClass
    {
        public static string ToNumber(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            input = input.ToUpperInvariant();

            var newNumber = new StringBuilder();
            foreach (var item in input)
            {
                newNumber.Append(item);
            }
            return newNumber.ToString();
        }
    }
}
