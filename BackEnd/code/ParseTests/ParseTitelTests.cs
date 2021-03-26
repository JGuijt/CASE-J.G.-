using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parsing;
using System;

namespace ParseTests
{
    [TestClass]
    public class ParseTitelTests
    {
   
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsExceptionIfDuurNotPresent()
        {
            TitelParser titelParser = new TitelParser();
            string input = "Duur: 5 dagen";
            titelParser.ParseTitel(input);


        }


        [TestMethod]
        public void ReturnsValueIfTitelIsPresent()
        {
            TitelParser titelParser = new TitelParser();
            string input = "Titel: C# Programmeren";
            string expectedOutput = "C# Programmeren";

            string actualOutput = titelParser.ParseTitel(input);

            Assert.AreEqual(expectedOutput, actualOutput);

        }




    }
}
