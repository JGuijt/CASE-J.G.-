using System;
using System.Collections.Generic;
using System.Text;

namespace TextInputMods
{
    public class Splitter
    {
        public string[] StringSplitter(string input)
        {
            string[] separator = new string[] { "\r\n" };
            string[] SplittedText = input.Split(
               separator, StringSplitOptions.None);

            return SplittedText;
        }

    }
}
