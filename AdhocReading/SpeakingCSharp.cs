using System.Text.RegularExpressions;

namespace AdhocReading
{
    [TestClass]
    public class SpeakingCSharp
    {
        [TestMethod]
        public void VariableName()
        {
            var todo = 1;
            Assert.AreEqual("todo",nameof(todo));
        }
        [TestMethod]
        public void CompareDouble()
        {
            var double1 = 0.1;
            var double2 = 0.2;
            Assert.IsFalse(double1 + double2 == 0.3);

            var decimal1 = 0.1M;
            var decimal2 = 0.2M;
            Assert.IsTrue(decimal1 + decimal2 == 0.3M);
        }
        [TestMethod]
        public void PatternMatching1()
        {
            object o1 = "3";
            Assert.IsFalse(o1 is int);

            object o2 = 3;
            Assert.IsTrue(o2 is int);
        }
        private int FibFunctional(int n) => n switch
        {
            1 => 0,
            2 => 1,
            _ => FibFunctional(n - 2) + FibFunctional(n - 1),
        };
        [TestMethod]
        public void FibTest()
        {
            Assert.AreEqual(0, FibFunctional(1));
            Assert.AreEqual(1, FibFunctional(2));
            Assert.AreEqual(1, FibFunctional(3));
            Assert.AreEqual(2, FibFunctional(4));
            Assert.AreEqual(3, FibFunctional(5));
        }
        [TestMethod]
        public void RegTest()
        {
            Regex numChecker = new(@"^\d+$");

            var num = "45";
            Assert.IsTrue(numChecker.IsMatch(num));

            var str = "hello";
            Assert.IsFalse(numChecker.IsMatch(str));

        }
    }
}
