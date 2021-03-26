using System;

namespace Parsing
{
    public class CursuscodeParser
    {
        public string ParseCode(string input)
        {
            if(!input.StartsWith("Cursuscode: "))
            {
                throw new ArgumentException("string should start with 'Cursuscode:'");
            }

            int indexValue = input.IndexOf(": ");
            string result = input.Substring(indexValue + 2);
            return result;

        }
    }
}