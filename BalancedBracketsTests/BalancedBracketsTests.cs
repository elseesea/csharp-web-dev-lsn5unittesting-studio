using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        /*
                BalancedBrackets bb;

                [TestInitialize]
                public void InitializeObject()
                {
                    bb = new BalancedBrackets();
                }
        */
        [TestMethod]
        public void TestOnlyBrackets()
        {
            string strTest = "[]";
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(strTest));
        }

        [TestMethod]
        public void TestOnOutside()
        {
            string strTest = "[LaunchCode]";
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(strTest));
        }

        [TestMethod]
        public void TestOnEnd()
        {
            string strTest = "Launch[Code]";
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(strTest));
        }

        [TestMethod]
        public void TestEmptyBracketsThenText()
        {
            string strTest = "[]LaunchCode";
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(strTest));
        }

        [TestMethod]
        public void TestLeftOnlyThenText()
        {
            string strTest = "[LaunchCode";
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(strTest));
        }

        [TestMethod]
        public void TestLeftOnlyAtEnd()
        {
            string strTest = "LaunchCode[";
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(strTest));
        }

        [TestMethod]
        public void TestLeftOnly()
        {
            string strTest = "[";
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(strTest));
        }

        [TestMethod]
        public void TestRightLeft()
        {
            string strTest = "][";
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(strTest));
        }

        [TestMethod]
        public void TestMoreRightsThanLeft()
        {
            string strTest = "ab[c]de]f[eu][[[]]]";
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(strTest));
        }

        [TestMethod]
        public void TestMoreLeftsThanRight()
        {
            string strTest = "ab[c]de[[]f[eu][][[[]]]";
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(strTest));
        }

        [TestMethod]
        public void TestBalancedBlanks()
        {
            string strTest = "[[]][[[[[[[]][[[]][]]]]]]]";
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(strTest));
        }



    }
}
