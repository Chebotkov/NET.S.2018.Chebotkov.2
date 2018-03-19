using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Filter.Tests
{
    /// <summary>
    /// This class contains tests for DigitFilterFunc
    /// </summary>
    [TestClass]
    public class FilterDigitTests
    {
        /// <summary>
        /// Test for DigitFilterFunc
        /// </summary>
        [TestMethod]
        public void DoFilterDigitFunc_DigitIs7()
        {
            int digit = 7;
            int[] initialArray = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int[] expectedArray = { 7, 7, 70, 17 };
            int[] result = FilterDigit.FilterDigitFunc(initialArray, digit);
            CollectionAssert.AreEqual(expectedArray, result);
        }

        /// <summary>
        /// Test for DigitFilterFunc
        /// </summary>
        [TestMethod]
        public void DoFilterDigitFunc_DigitIs6()
        {
            int digit = 6;
            int[] initialArray = { 7, 1, 2, -3, 4, 5, -6, 7, 68, 69, -70, 15, 17 };
            int[] expectedArray = { -6, 68, 69 };
            int[] result = FilterDigit.FilterDigitFunc(initialArray, digit);
            CollectionAssert.AreEqual(expectedArray, result);
        }

        /// <summary>
        /// Test for DigitFilterFunc
        /// </summary>
        [TestMethod]
        public void DoFilterDigitFunc_DigitIs5()
        {
            int digit = 5;
            int[] initialArray = { 7, 1, 2, 35, 4, 5, 63, 7, 68, 69, 70, 15, 17, 55, 22, 55, 55 };
            int[] expectedArray = { 35, 5, 15, 55, 55, 55 };
            int[] result = FilterDigit.FilterDigitFunc(initialArray, digit);
            CollectionAssert.AreEqual(expectedArray, result);
        }

        /// <summary>
        /// Test for DigitFilterFunc
        /// </summary>
        [TestMethod]
        public void DoFilterDigitFunc_DigitIs0()
        {
            int digit = 0;
            int[] initialArray = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 71, 15, 17 };
            int[] expectedArray = { };
            int[] result = FilterDigit.FilterDigitFunc(initialArray, digit);
            CollectionAssert.AreEqual(expectedArray, result);
        }

        /// <summary>
        /// Test for DigitFilterFunc
        /// </summary>
        [TestMethod]
        public void DoFilterDigitFunc_DigitIs1()
        {
            int digit = 1;
            int[] initialArray = { };
            int[] expectedArray = { };
            int[] result = FilterDigit.FilterDigitFunc(initialArray, digit);
            CollectionAssert.AreEqual(expectedArray, result);
        }
    }
}