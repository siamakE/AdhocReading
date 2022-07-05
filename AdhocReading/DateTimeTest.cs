using System;
using System.IO;

namespace AdhocReading
{
    [TestClass]
    public class DateTimeTest
    {
        [TestMethod]
        public void ChangeConvertFromUnixToHumanReadable()
        {
            var claimExpireDate = 1657023654;
            var todo1 = DateTimeOffset.FromUnixTimeSeconds(claimExpireDate);
            var claimAuthTime = 1657020054;
            var todo2 = DateTimeOffset.FromUnixTimeSeconds(claimAuthTime);
            var exDate = DateTimeOffset.Now.ToUnixTimeSeconds() + claimExpireDate - claimAuthTime;

            var str = exDate.ToString();

            DateTimeOffset dt = DateTimeOffset.FromUnixTimeSeconds(exDate);
            Assert.IsTrue(DateTimeOffset.UtcNow < dt);
        }
        
    }
}