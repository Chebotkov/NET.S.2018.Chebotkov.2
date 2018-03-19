using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IN_MSTests
{
    /// <summary>
    /// Test class for InsertNumbers
    /// </summary>
    [TestClass]
    public class INTests
    {
        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        public void IN_151500_15()
        {
            //Arange
            int firstNum = 15, secondNum = 15, firstIndex = 0, secondIndex = 0;
            int expectedResult = 15;

            //Act
            int result = InsertNumberLib.Library.InsertNumber(firstNum, secondNum, firstIndex, secondIndex);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        public void IN_81500_9()
        {
            //Arange
            int firstNum = 8, secondNum = 15, firstIndex = 0, secondIndex = 0;
            int expectedResult = 9;

            //Act
            int result = InsertNumberLib.Library.InsertNumber(firstNum, secondNum, firstIndex, secondIndex);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        public void IN_81538_120()
        {
            //Arange
            int firstNum = 8, secondNum = 15, firstIndex = 3, secondIndex = 8;
            int expectedResult = 120;

            //Act
            int result = InsertNumberLib.Library.InsertNumber(firstNum, secondNum, firstIndex, secondIndex);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IN_81583_IndexOutOfRangeException()
        {
            //Arange
            int firstNum = 8, secondNum = 15, firstIndex = 8, secondIndex = 3;

            //Act
            int result = InsertNumberLib.Library.InsertNumber(firstNum, secondNum, firstIndex, secondIndex);
        }
    }
}