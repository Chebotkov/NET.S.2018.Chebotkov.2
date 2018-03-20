using System.Collections.Generic;
using System;

namespace FindNextBiggerNumberLib
{
    /// <summary>
    /// This class contains FindNextBiggerNumber 
    /// </summary>
    public static class FNBN
    {
        #region FNBNMethod
        /// <summary>
        /// This method is find the nearest biggest number which consists of digits of received number
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>"-1" if argument is out of range
        /// and int number if it was correct</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when received negative number</exception>
        public static int FindNextBiggerNumber(int number)
        {
            if (number <= 0 || number > Int32.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Invalid value. Positive integer number was expected.");
            }

            List<int> array = new List<int>();

            while (number > 0)
            {
                array.Insert(0, number % 10);
                number /= 10;
            }

            return GetNubmer(array.ToArray());
        }

        /// <summary>
        /// This method is find the nearest biggest number which consists of digits of received number
        /// and measures program execution time
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="time">Program execution time</param>
        /// <returns>"-1" if argument is out of range
        /// and int number if it was correct</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when received negative number</exception>
        public static int FindNextBiggerNumberWithTimeByOut(int number, out int time)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            if (number <= 0 || number > Int32.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Invalid value. Positive integer number was expected.");
            }

            List<int> array = new List<int>();

            while (number > 0)
            {
                array.Insert(0, number % 10);
                number /= 10;
            }

            sw.Stop();
            time = (int)sw.ElapsedMilliseconds;
            
            return GetNubmer(array.ToArray());
        }

        /// <summary>
        /// This method is find the nearest biggest number which consists of digits of received number
        /// and measures program execution time
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Returns cortege {int; double;} which contains result and time of execution</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when received negative number</exception>
        public static Tuple<int, double> FindNextBiggerNumberWithTime(int number)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            if (number <= 0 || number > Int32.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Invalid value. Positive integer number was expected.");
            }

            List<int> array = new List<int>();

            while (number > 0)
            {
                array.Insert(0, number % 10);
                number /= 10;
            }

            sw.Stop();
           
            return Tuple.Create(GetNubmer(array.ToArray()), sw.ElapsedMilliseconds / 100.0);
        }
        #endregion

        #region helpful methods for FNVNMethod
        /// <summary>
        /// This Method goes throw the array from the end to the top and 
        /// find next bigger digit after current. Then it's replace the current digit with the biggest one and
        /// sorts previous digits ascending.
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Number</returns>
        private static int GetNubmer(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] > array[i - 1])
                {
                    ReplaceDigits(ref array[i], ref array[i - 1]);
                    if (i != array.Length - 1)
                    {
                        SotringLib.Sorting.QuickSort(array, i, array.Length - 1);
                    }

                    return ConcatenateDigits(array);
                }
            }

            return -1;
        }

        /// <summary>
        /// Method Gets array of integers and return concatenation of digits into one number
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Number</returns>
        private static int ConcatenateDigits(int[] array)
        {
            string number;
            number = String.Concat(array);

            return Convert.ToInt64(number) > (long)Int32.MaxValue ? -1 : Convert.ToInt32(number);

            /*int number=0, increment = 1;
            for (int i=array.Length-1; i>0; i--, increment *= 10)
            {
                number += array[i] * increment;
            }
            return (long)(number + array[0] * increment) > Int32.MaxValue ? -1 : number += array[0] * increment;*/
        }

        /// <summary>
        /// This method replace two digits in array
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="index1">First index</param>
        /// <param name="index2">Second index</param>
        private static void ReplaceDigits(ref int firstNumber, ref int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
        #endregion
    }
}