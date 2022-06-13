using System.Collections.Generic;
using WorkingWithEFCore;

namespace AdhocReading.Tests.DatabaseTests
{
    public class TestDatabaseContainer
    {
        private readonly Dictionary<string, object[]> _testData;

        public NorthwindContext _northwindContext { get; }

        public TestDatabaseContainer(
            NorthwindContext northwindContext,
            Dictionary<string, object[]> testData)
        {
            _northwindContext = northwindContext;
            _testData = testData;
        }
        public void Go()
        {
            foreach (var item in _testData)
            {
                _northwindContext.AddRange(item.Value);
                _northwindContext.SaveChanges();
            }
        }
    }
}