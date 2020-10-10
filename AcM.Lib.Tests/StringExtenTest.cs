using AcM.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcM.Lib.Tests
{
    [TestClass]
    public class StringExtenTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod()]
        public void ConvertToTitleCase()
        {
            var source = "the return of the king";
            var expected = "The Return Of The King";
            var result = source.ConvertToTitleCase();
            
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }
    }
}
