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
            int[] initialArray = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int[] expectedArray = { 7, 7, 70, 17 };
            IPredicate predicate = new PredicateDemo(7);
            int[] result = FilterDigit.FilterDigitFunc(initialArray, predicate);
            CollectionAssert.AreEqual(expectedArray, result);
        }

        /// <summary>
        /// Test for DigitFilterFunc
        /// </summary>
        [TestMethod]
        public void DoFilterDigitFunc_DigitIs6()
        {
            int[] initialArray = { 7, 1, 2, -3, 4, 5, -6, 7, 68, 69, -70, 15, 17 };
            int[] expectedArray = { -6, 68, 69 };
            IPredicate predicate = new PredicateDemo(6);
            int[] result = FilterDigit.FilterDigitFunc(initialArray, predicate);
            CollectionAssert.AreEqual(expectedArray, result);
        }

        /// <summary>
        /// Test for DigitFilterFunc
        /// </summary>
        [TestMethod]
        public void DoFilterDigitFunc_DigitIs5()
        {
            int[] initialArray = { 7, 1, 2, 35, 4, 5, 63, 7, 68, 69, 70, 15, 17, 55, 22, 55, 55 };
            int[] expectedArray = { 35, 5, 15, 55, 55, 55 };
            IPredicate predicate = new PredicateDemo(5);
            int[] result = FilterDigit.FilterDigitFunc(initialArray, predicate);
            CollectionAssert.AreEqual(expectedArray, result);
        }

        /// <summary>
        /// Test for DigitFilterFunc
        /// </summary>
        [TestMethod]
        public void DoFilterDigitFunc_DigitIs0()
        {
            int[] initialArray = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 71, 15, 17 };
            int[] expectedArray = { };
            IPredicate predicate = new PredicateDemo(0);
            int[] result = FilterDigit.FilterDigitFunc(initialArray, predicate);
            CollectionAssert.AreEqual(expectedArray, result);
        }

        /// <summary>
        /// Test for DigitFilterFunc
        /// </summary>
        [TestMethod]
        public void DoFilterDigitFunc_DigitIs1()
        {
            int[] initialArray = { };
            int[] expectedArray = { };
            IPredicate predicate = new PredicateDemo(1);
            int[] result = FilterDigit.FilterDigitFunc(initialArray, predicate);
            CollectionAssert.AreEqual(expectedArray, result);
        }
    }
}