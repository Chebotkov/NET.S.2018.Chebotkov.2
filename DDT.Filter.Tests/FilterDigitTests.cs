﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Filter;
using Filter.Tests;

namespace DDT.Filter.Tests
{
    /// <summary>
    /// This class contains tests for FilterDigitFunc
    /// </summary>
    [TestClass]
    public class FilterDigitTests
    {
        /// <summary>
        /// The property for access to Arrays.xml
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Tests for FilterDigitFunc
        /// </summary>
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Arrays.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem(@"DDT.Filter.Tests\Arrays.xml")]
        [TestMethod]
        public void DoFilterDigitFunc()
        {
            int[] initialArray = ParseToArray.GetArray(TestContext.DataRow["InitialArray"].ToString());
            int[] expectedArray = ParseToArray.GetArray(TestContext.DataRow["ExpectedArray"].ToString());
            int digit = Convert.ToInt32(TestContext.DataRow["Digit"]);
            IPredicate predicate = new PredicateDemo(digit);
            int[] result = FilterDigit.FilterDigitFunc(initialArray, predicate);
            CollectionAssert.AreEqual(expectedArray, result);
        }
    }
}
