using Microsoft.Extensions.DependencyInjection;
using PacktLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithEFCore;

namespace AdhocReading.Tests.DatabaseTests
{
    [TestClass]
    public class EfTests : DatabaseTestBase
    {
        [TestMethod]
        public void IsDatabaseAvailable()
        {
            var categories = NorthwindContext.Categories.ToList();
            Assert.IsTrue(categories.Count > 0);

        }
    }
}
