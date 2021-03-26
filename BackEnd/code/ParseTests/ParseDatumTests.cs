using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parsing;
using System;

namespace ParseTests
{
    [TestClass]
    public class ParseDatumTests
    {
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowIfDatumNotPresent()
        {
            DatumParser datumParser = new DatumParser();
            string input = "Titel: THR";
            datumParser.ParseDatum(input);


        }



        [TestMethod]
        public void ReturnsValueIfCursuscodeIsPresent()
        {
            DatumParser datumParser = new DatumParser();
            string input = "Startdatum: 16/06/2021";
            datumParser.ParseDatum(input);

            DateTime expectedResult = new DateTime(2021, 06, 16);
            DateTime actualResult = datumParser.ParseDatum(input);

            Assert.AreEqual(expectedResult, actualResult);

        }




    }
}
