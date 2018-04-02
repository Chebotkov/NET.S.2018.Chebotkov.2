using System.Collections.Generic;
using System.Linq;
using System;

namespace Filter
{
    /// <summary>
    /// This class contains filter method/
    /// </summary>
    public static class FilterDigit
    {
        #region public
        /// <summary>
        /// Method gets array of integers. Then it 
        /// scans received array for numbers by predicate
        /// and puts them into a new array.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="predicate">The way of choosing.</param>
        /// <returns>Return new Array.</returns>
        /// <exception cref="System.ArgumentNullException">Throws when array or predicate is null.</exception>
        public static int[] FilterDigitFunc(int[] array, IPredicate predicate)
        {
            if (ReferenceEquals(array, null))
            {
                throw new ArgumentNullException("Array can't be null");
            }

            if (ReferenceEquals(predicate, null))
            {
                throw new ArgumentNullException("Predicate can't be null");
            }

            List<int> temp = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate.Predicate(array[i]))
                {
                    temp.Add(array[i]);
                }
            }

            return temp.ToArray<int>();
        }
        #endregion
    }
}