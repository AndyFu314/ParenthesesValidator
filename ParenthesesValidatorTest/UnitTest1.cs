using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParenthesesValidator;


namespace ParenthesesValidatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_ValidString_左左右右()
        {
            // arragne
            var testSting = "(())";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_InvalidString_右右左左()
        {
            // arragne
            var testSting = "))((";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_ValidString_左星右()
        {
            // arragne
            var testSting = "(*)";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_ValidString_左星星右()
        {
            // arragne
            var testSting = "(**)";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_InvalidString_星右右()
        {
            // arragne
            var testSting = "*))";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_ValidString_星星右右左左左星星星()
        {
            // arragne
            var testSting = "**))(((***";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_InvalidString_左右右右左左()
        {
            // arragne
            var testSting = "()))((";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_ValidString_星星左右右右左左星星()
        {
            // arragne
            var testSting = "**()))((**";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_ValidString_星星右右左左星星()
        {
            // arragne
            var testSting = "**))((**";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_ValidString_左星右左星右()
        {
            // arragne
            var testSting = "(*)(*)";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_ValidString_左左星右左星右右左右()
        {
            // arragne
            var testSting = "((*)(*))()";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_InvalidString_星星右右左左左星星()
        {
            // arragne
            var testSting = "**))(((**";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_ValidString_左右星星右右()
        {
            // arragne
            var testSting = "()**))";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_InvalidString_左右星右右()
        {
            // arragne
            var testSting = "()*))";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_ValidString_左左右星右右()
        {
            // arragne
            var testSting = "(()*))";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_ValidString_星星星星星()
        {
            // arragne
            var testSting = "*****";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_InvalidString_左星星右左()
        {
            // arragne
            var testSting = "(**)(";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_InvalidString_左左星右左星右星星右右左()
        {
            // arragne
            var testSting = "((*)(*)**))(";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_InvalidString_左星星右右右右星左星()
        {
            // arragne
            var testSting = "(**))))*(*";

            // act
            var result = testSting.IsValidParentheses();

            // assert
            Assert.IsFalse(result);
        }
    }
}
