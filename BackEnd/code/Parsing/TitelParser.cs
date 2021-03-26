using System;

namespace Parsing
{
    public class TitelParser
    {
        public string ParseTitel(string input)
        {
            string result;
            if (!input.StartsWith("Titel: "))
            {
                throw new ArgumentException("string must start with 'Titel: '");
            }


            try
            {
                int valueIndex = input.IndexOf(": ");
                string substring = input.Substring(valueIndex + 2);
                return result = substring;

            }
            catch
            {
                throw new IndexOutOfRangeException();
            }
            

        }
    }
}