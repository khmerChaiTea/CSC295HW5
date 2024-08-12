using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC295HW5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295HW5.Tests
{
    [TestClass]
    public class ParenthesisCheckerTests
    {
        /// <summary>
        /// Tests if a simple expression with a single type of balanced parentheses returns true.
        /// </summary>
        [TestMethod]
        public void TestSingleTypeBalanced()
        {
            bool result = ParenthesisChecker.IsBalanced("()");
            Assert.IsTrue(result, "Expected balanced parentheses to return true.");
        }

        /// <summary>
        /// Tests if an expression with mixed types of balanced parentheses returns true.
        /// </summary>
        [TestMethod]
        public void TestMixedTypeBalanced()
        {
            bool result = ParenthesisChecker.IsBalanced("{[()]}");
            Assert.IsTrue(result, "Expected mixed type balanced parentheses to return true.");
        }

        /// <summary>
        /// Tests if an expression with unbalanced parentheses returns false.
        /// </summary>
        [TestMethod]
        public void TestUnbalanced()
        {
            bool result = ParenthesisChecker.IsBalanced("{[()]}[");
            Assert.IsFalse(result, "Expected unbalanced parentheses to return false.");
        }

        /// <summary>
        /// Tests if an empty string returns true, as it has no unbalanced parentheses.
        /// </summary>
        [TestMethod]
        public void TestEmptyString()
        {
            bool result = ParenthesisChecker.IsBalanced("");
            Assert.IsTrue(result, "Expected empty string to return true.");
        }

        /// <summary>
        /// Tests if an expression with a single type of unbalanced parentheses returns false.
        /// </summary>
        [TestMethod]
        public void TestSingleTypeUnbalanced()
        {
            bool result = ParenthesisChecker.IsBalanced("(()");
            Assert.IsFalse(result, "Expected unbalanced parentheses to return false.");
        }
    }
}
