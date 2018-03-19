using NUnit.Framework;

namespace IN_NUnitTests
{
    /// <summary>
    /// Test class for InsertNumber method.
    /// </summary>
    [TestFixture]
    public class INTests
    {
        /// <summary>
        /// Tests for InsertNumber
        /// </summary>
        /// <param name="fn">First number</param>
        /// <param name="sn">Second number</param>
        /// <param name="fi">First index</param>
        /// <param name="si">Second index</param>
        /// <param name="expectedResult">Expected result</param>
        [TestCase(15, 15, 0, 0, 15)]
        [TestCase(8, 15, 0, 0, 9)]
        [TestCase(8, 15, 3, 8, 120)]
        public void TestsForInsertNumber(int fn, int sn, int fi, int si, int expectedResult)
        {
            int result = InsertNumberLib.Library.InsertNumber(fn, sn, fi, si);

            Assert.AreEqual(expectedResult, result);
        }
    }
}