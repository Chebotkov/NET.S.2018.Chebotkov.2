using System.Collections.Generic;
using System.Linq;

namespace Filter
{
    /// <summary>
    /// This class contains filter method/
    /// </summary>
    public static class FilterDigit
    {
        #region public
        /// <summary>
        /// Method gets array of integers and digit. Then it 
        /// scans received array for numbers which contains specified digit
        /// and puts them in new array.
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="digit">Filtration digit</param>
        /// <returns>Return new Array</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">Throws when variable "digit" isn't a digit</exception>
        public static int[] FilterDigitFunc(int[] array, int digit)
        {
            if (digit > 9 || digit < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }

            List<int> temp = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (IsNumberContainsDigit(array[i], digit))
                {
                    temp.Add(array[i]);
                }
            }

            return temp.ToArray<int>();
        }
        #endregion

        #region private
        /// <summary>
        /// Method checks if number contains specified digit.
        /// </summary>
        /// <param name="number">Entered number</param>
        /// <param name="digit">Filtration digit</param>
        /// <returns>Return true if number contains specified digit and false if it isn't. </returns>
        private static bool IsNumberContainsDigit(int number, int digit)
        {
            if (number < 0)
            {
                number *= -1;
            }

            while (number > 0)
            {
                if (number % 10 == digit)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
        #endregion
    }
}