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
        /// <summary>
        /// Tests if a simple expression with a single type of balanced parentheses returns true.
        /// </summary>
        [TestMethod]
        public void TestSingleTypeBalanced()
        {
            Assert.IsTrue(ParenthesisChecker.isBalanced("()"));
        }

        /// <summary>
        /// Tests if an expression with mixed types of balanced parentheses returns true.
        /// </summary>
        [TestMethod]
        public void TestMixedTypeBalanced()
        {
            Assert.IsTrue(ParenthesisChecker.isBalanced("{[()]}"));
        }

        /// <summary>
        /// Tests if an expression with unbalanced parentheses returns false.
        /// </summary>
        [TestMethod]
        public void TestUnbalanced()
        {
            Assert.IsFalse(ParenthesisChecker.isBalanced("{[()]}["));
        }

        /// <summary>
        /// Tests if an empty string returns true, as it has no unbalanced parentheses.
        /// </summary>
        [TestMethod]
        public void TestEmptyString()
        {
            Assert.IsTrue(ParenthesisChecker.isBalanced(""));
        }

        /// <summary>
        /// Tests if an expression with a single type of unbalanced parentheses returns false.
        /// </summary>
        [TestMethod]
        public void TestSingleTypeUnbalanced()
        {
            Assert.IsFalse(ParenthesisChecker.isBalanced("(()"));
        }
    }
}