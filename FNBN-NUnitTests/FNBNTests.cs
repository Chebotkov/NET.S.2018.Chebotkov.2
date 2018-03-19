using NUnit.Framework;

namespace FNBN_NUnitTests
{
    /// <summary>
    /// Test Class. Contains test methods for FindNextBiggerNumber method.
    /// </summary>
    [TestFixture]
    public class FNBNTests
    {
        /// <summary>
        /// Test method
        /// </summary> 
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(414, 441)]
        [TestCase(144, 414)]
        [TestCase(1234321, 1241233)]
        [TestCase(1234126, 1234162)]
        [TestCase(3456432, 3462345)]
        [TestCase(10, -1)]
        [TestCase(20, -1)]
        [TestCase(1999888877, -1)]
        public void TestsForFindNextBiggerNumber(int enteredNumber, int expectedResult)
        {
            int result = FindNextBiggerNumberLib.FNBN.FindNextBiggerNumber(enteredNumber);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
