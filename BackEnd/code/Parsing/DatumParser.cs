using System;

namespace Parsing
{
    public class DatumParser
    {
        public DateTime ParseDatum(string input)
        {
            if (!input.StartsWith("Startdatum: "))
            {
                throw new ArgumentException("string must Contain 'Startdatum: '");
            }

            

            try
            {
                int valueIndex = input.IndexOf(": ");
                string substring = input.Substring(valueIndex + 2);
                DateTime result = DateTime.Parse(substring);
                return result;
            }
            catch
            {
                throw new ArgumentException("Index is out of range");
            }

        }
    }
}