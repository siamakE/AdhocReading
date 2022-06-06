using WorkingWithEFCore;

namespace AdhocReading
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void DatabaseProvider()
        {
            Assert.AreEqual("SQLServer", ProjectConstants.DatabaseProvider);
        }
    }
}
