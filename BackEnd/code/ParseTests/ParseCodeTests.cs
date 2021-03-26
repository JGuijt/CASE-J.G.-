using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parsing;
using System;

namespace ParseTests
{
    [TestClass]
    public class ParseCodeTests
    {
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowIfCursuscodeNotPresent()
        {
            CursuscodeParser codeParser = new CursuscodeParser();
            string input = "Titel: Blazor";
            codeParser.ParseCode(input);


        }



        [TestMethod]
        public void ReturnsValueIfCursuscodeIsPresent()
        {
            CursuscodeParser cursuscodeParser = new CursuscodeParser();
            string input = "Cursuscode: LNQ";
            
            string expectedResult = "LNQ";
            string actualResult = cursuscodeParser.ParseCode(input);

            Assert.AreEqual(expectedResult, actualResult);

        }




    }
}
