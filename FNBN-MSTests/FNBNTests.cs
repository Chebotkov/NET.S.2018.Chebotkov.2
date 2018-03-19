using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FNBN_MSTests
{
    /// <summary>
    /// Test Class. Contains test methods for FindNextBiggerNumber method.
    /// </summary>
    [TestClass]
    public class FNBNTests
    {
        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void FNBN_12_21()
        {
            //Arange
            int enteredNumber = 12;
            int expectedResult = 21;

            //Act
            int result = FindNextBiggerNumberLib.FNBN.FindNextBiggerNumber(enteredNumber);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void FNBN_513_531()
        {
            //Arange
            int enteredNumber = 513;
            int expectedResult = 531;

            //Act
            int result = FindNextBiggerNumberLib.FNBN.FindNextBiggerNumber(enteredNumber);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void FNBN_414_441()
        {
            //Arange
            int enteredNumber = 414;
            int expectedResult = 441;

            //Act
            int result = FindNextBiggerNumberLib.FNBN.FindNextBiggerNumber(enteredNumber);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void FNBN_1234321_1241233()
        {
            //Arange
            int enteredNumber = 1234321;
            int expectedResult = 1241233;

            //Act
            int result = FindNextBiggerNumberLib.FNBN.FindNextBiggerNumber(enteredNumber);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void FNBN_3456432_3462345()
        {
            //Arange
            int enteredNumber = 3456432;
            int expectedResult = 3462345;

            //Act
            int result = FindNextBiggerNumberLib.FNBN.FindNextBiggerNumber(enteredNumber);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void FNBN_10_minus1()
        {
            //Arange
            int enteredNumber = 10;
            int expectedResult = -1;

            //Act
            int result = FindNextBiggerNumberLib.FNBN.FindNextBiggerNumber(enteredNumber);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void FNBN_111_minus1()
        {
            //Arange
            int enteredNumber = 111;
            int expectedResult = -1;

            //Act
            int result = FindNextBiggerNumberLib.FNBN.FindNextBiggerNumber(enteredNumber);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void FNBN_2017_2071()
        {
            //Arange
            int enteredNumber = 2017;
            int expectedResult = 2071;

            //Act
            int result = FindNextBiggerNumberLib.FNBN.FindNextBiggerNumber(enteredNumber);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}