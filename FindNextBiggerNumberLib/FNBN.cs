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
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int FindNextBiggerNumber(int number)
        {
            if (number <= 0 || number > Int32.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
                //return -1;
            }

            List<int> array = new List<int>();

            while (number > 0)
            {
                array.Insert(0, number % 10);
                number /= 10;
            }

            try
            {
                return GetNubmer(array.ToArray());
            }
            catch (OverflowException)
            {
                return -1;
            }
        }

        /// <summary>
        /// This method is find the nearest biggest number which consists of digits of received number
        /// and measures program execution time
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="time">Program execution time</param>
        /// <returns>"-1" if argument is out of range
        /// and int number if it was correct</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int FindNextBiggerNumberWithTimeByOut(int number, out int time)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            if (number <= 0 || number > Int32.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
                //return -1;
            }

            List<int> array = new List<int>();

            while (number > 0)
            {
                array.Insert(0, number % 10);
                number /= 10;
            }

            sw.Stop();
            time = (int)sw.ElapsedMilliseconds;

            try
            {
                return GetNubmer(array.ToArray());
            }
            catch (OverflowException)
            {
                return -1;
            }
        }

        /// <summary>
        /// This method is find the nearest biggest number which consists of digits of received number
        /// and measures program execution time
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="time">Program execution time</param>
        /// <returns>"-1" if argument is out of range
        /// and int number if it was correct</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int FindNextBiggerNumberWithTimeByRef(int number, ref int time)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            if (number <= 0 || number > Int32.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
                //return -1;
            }

            List<int> array = new List<int>();

            while (number > 0)
            {
                array.Insert(0, number % 10);
                number /= 10;
            }

            sw.Stop();
            time = (int)sw.ElapsedMilliseconds;

            try
            {
                return GetNubmer(array.ToArray());
            }
            catch (OverflowException)
            {
                return -1;
            }
        }

        /// <summary>
        /// This method is find the nearest biggest number which consists of digits of received number
        /// and measures program execution time
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Returns cortege {int; double;} which contains result and time of execution</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Tuple<int, double> FindNextBiggerNumberWithTime(int number)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            if (number <= 0 || number > Int32.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
                //return -1;
            }

            List<int> array = new List<int>();

            while (number > 0)
            {
                array.Insert(0, number % 10);
                number /= 10;
            }

            sw.Stop();

            try
            {
                return Tuple.Create(GetNubmer(array.ToArray()), sw.ElapsedMilliseconds / 100.0);
            }
            catch (OverflowException)
            {
                return Tuple.Create(-1, 0d);
            }
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
                    ReplaceDigits(array, i, i - 1);
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
            return Convert.ToInt32(number);

            /*int number=0, increment = 1;
            for (int i=0; i<array.Length, i++)
            {
                number += array[i] * increment;
                increment *= 10;
            }
            return number;*/
        }

        /// <summary>
        /// This method replace two digits in array
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="index1">First index</param>
        /// <param name="index2">Second index</param>
        private static void ReplaceDigits(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        #endregion
    }
}