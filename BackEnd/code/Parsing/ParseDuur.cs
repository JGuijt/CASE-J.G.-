using System;

namespace Parsing
{

    public class DuurParser
    {
        

        public int ParseDuur(string input)
        {
            
            if (!input.StartsWith("Duur: "))
            {
                throw new ArgumentException("string must Contain 'Duur: '");
            }

            int valueIndex = input.IndexOf(": ");            
            string substring = input.Substring(valueIndex + 2, 1);

            try
            {
                int result = int.Parse(substring);
                return result;
            }
            catch
            {
                throw new ArgumentException("Index is out of range");
            }
            
        }
    }
}
