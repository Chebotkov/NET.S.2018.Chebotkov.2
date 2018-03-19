using System;
using System.Collections.Generic;
using System.Linq;

namespace DDT.Filter.Tests
{
    /// <summary>
    /// This class contains method which convert string to array of integers
    /// </summary>
    public static class ParseToArray
    {
        /// <summary>
        /// This method convert string to array of integers
        /// </summary>
        /// <param name="s">Received string</param>
        /// <returns>Array<int></returns>
        public static int[] GetArray(string s)
        {
            List<int> numbers = new List<int>();
            if (!String.IsNullOrEmpty(s))
            {
                string[] num = s.Split(',');
                for (int i = 0; i < num.Length; i++)
                {
                    numbers.Add(Convert.ToInt32(num[i]));
                }
            }

            return numbers.ToArray<int>();
        }
    }
}
