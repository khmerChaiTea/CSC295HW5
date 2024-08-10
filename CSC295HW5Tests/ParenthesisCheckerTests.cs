using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC295HW5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295HW5.Tests
{
    [TestClass()]
    public class ParenthesisCheckerTests
    {
        [TestMethod]
        public void TestSingleTypeBalanced()
        {
            Assert.IsTrue(ParenthesisChecker.isBalanced("()"));
        }

        [TestMethod]
        public void TestMixedTypeBalanced()
        {
            Assert.IsTrue(ParenthesisChecker.isBalanced("{[()]}"));
        }

        [TestMethod]
        public void TestUnbalanced()
        {
            Assert.IsFalse(ParenthesisChecker.isBalanced("{[()]}["));
        }

        [TestMethod]
        public void TestEmptyString()
        {
            Assert.IsTrue(ParenthesisChecker.isBalanced(""));
        }

        [TestMethod]
        public void TestSingleTypeUnbalanced()
        {
            Assert.IsFalse(ParenthesisChecker.isBalanced("(()"));
        }
    }
}