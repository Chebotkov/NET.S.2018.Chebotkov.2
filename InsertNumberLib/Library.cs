using System;

namespace InsertNumberLib
{
    /// <summary>
    /// This class contains InsertNumber method
    /// </summary>
    public static class Library
    {
        #region InsertNumber method
        /// <summary>
        /// This method enters bits from the second number
        /// to the to range of positions [firstIndex, secondIndex] of first number.
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <param name="firstIndex">First index</param>
        /// <param name="secondIndex">Second index</param>
        /// <exception cref="ArgumentOutOfRangeException">Throws when received wrong range of indices</exception>
        /// <returns></returns>
        public static int InsertNumber(int firstNumber, int secondNumber, int firstIndex, int secondIndex)
        {
            if (secondIndex < firstIndex)
            {
                throw new IndexOutOfRangeException("Wrong range of indices.");
            }

            int[] firstNumArray = GetBinaryRepresentationOfNumber(firstNumber);
            int[] secondNumArray = GetBinaryRepresentationOfNumber(secondNumber);
            for (int i = firstNumArray.Length - 1 - firstIndex, j = firstNumArray.Length - 1; i >= firstNumArray.Length - 1 - secondIndex; i--, j--)
            {
                firstNumArray[i] = secondNumArray[j];
            }

            return GetNumberFromBinaryArray(firstNumArray);
        }
        #endregion

        #region Necessaire methods 
        /// <summary>
        /// Method returns binary representation of received number.
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Array of integer numbers</returns>
        private static int[] GetBinaryRepresentationOfNumber(int number)
        {
            int[] binaryArray = new int[32];
            int i = binaryArray.Length - 1;
            while (number >= 1)
            {
                if (number % 2 == 0)
                {
                    binaryArray[i] = 0;
                }
                else
                {
                    binaryArray[i] = 1;
                }

                number /= 2;
                i--;
            }

            return binaryArray;
        }

        /// <summary>
        /// Method returns decimal representation of received array.
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Number</returns>
        private static int GetNumberFromBinaryArray(int[] array)
        {
            int number = 0;
            for (int i = array.Length - 1, power = 1; i >= 0; i--, power *= 2)
            {
                number += array[i] * power;
            }

            return number;
        }
        #endregion
    }
}