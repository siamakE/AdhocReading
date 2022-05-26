using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdhocReading
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Func<string, string> selector = str => str.ToUpper();
            string[] words = { "orange", "apple", "Article", "elephant" };
            var aWords = words.Select(selector).ToArray();

            for(int i = 0; i < aWords.Length; i++) 
                Assert.AreEqual(words[i].ToUpper(), aWords[i]);
        }
        delegate string ConvertMethod(string inString);
        private static string UppercaseString(string inputString)
        {
            return inputString.ToUpper();
        }
        [TestMethod]
        public void TestMethod2()
        {
            ConvertMethod convertMeth = UppercaseString;

            string[] words = { "orange", "apple", "Article", "elephant" };
            var aWords = words.Select(x=> convertMeth(x)).ToArray();

            for (int i = 0; i < aWords.Length; i++)
                Assert.AreEqual(words[i].ToUpper(), aWords[i]);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Func<string, string> convertMethod = UppercaseString;

            string[] words = { "orange", "apple", "Article", "elephant" };
            var aWords = words.Select(convertMethod).ToArray();

            for (int i = 0; i < aWords.Length; i++)
                Assert.AreEqual(words[i].ToUpper(), aWords[i]);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Func<string, string> convertMethod = s => s.ToUpper();

            string[] words = { "orange", "apple", "Article", "elephant" };
            var aWords = words.Select(convertMethod).ToArray();

            for (int i = 0; i < aWords.Length; i++)
                Assert.AreEqual(words[i].ToUpper(), aWords[i]);
        }
        [TestMethod]
        public void TestMethod5()
        {
            static string convertMethod(string s) => s.ToUpper();

            string[] words = { "orange", "apple", "Article", "elephant" };
            var aWords = words.Select(convertMethod).ToArray();

            for (int i = 0; i < aWords.Length; i++)
                Assert.AreEqual(words[i].ToUpper(), aWords[i]);
        }
    }
}