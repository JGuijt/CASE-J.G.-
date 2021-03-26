using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parsing;
using System;

namespace ParseTests
{
    [TestClass]
    public class ParseDuurTests
    {
       
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsExceptionIfDuurNotPresent()
        {
            DuurParser duurParser = new DuurParser();
            string input = "Title: 5 dagen";
            duurParser.ParseDuur(input);
        }


       
        [TestMethod]
        public void ReturnsValueIfDuurIsPresent()
        {
            DuurParser duurParser = new DuurParser();
            string input = "Duur: 5 dagen";
            int expectedOutput = 5;

            int actualOutput = duurParser.ParseDuur(input);

            Assert.AreEqual(expectedOutput, actualOutput);

        }




    }
}
