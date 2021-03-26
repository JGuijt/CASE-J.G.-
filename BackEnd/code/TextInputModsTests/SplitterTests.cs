using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextInputMods;

namespace TextInputModsTests
{
    [TestClass]
    public class SplitterTests
    {
        [TestMethod]
        public void SplitterShouldSplitAtNewLine()
        {
            Splitter splitter = new Splitter();
            string input = "Titel: C# Programmeren\r\nCursuscode: CNETIN\r\n";
            string[] expectedOutput = { "Titel: C# Programmeren", "Cursuscode: CNETIN", "" };
            string[] actualOutput = splitter.StringSplitter(input);



            CollectionAssert.AreEqual(expectedOutput, actualOutput);
            


        }
    }
}
