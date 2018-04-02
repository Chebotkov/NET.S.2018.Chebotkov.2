using System;

namespace Filter.Tests
{
    /// <summary>
    /// Implements Predicate method.
    /// </summary>
    public class PredicateDemo : IPredicate
    {
        private int digit;

        public PredicateDemo(int digit)
        {
            if (digit < 0 || digit > 9)
            {
                throw new ArgumentNullException("It's not a digit.");
            }

            this.digit = digit;
        }

        /// <summary>
        /// Method checks if number contains specified digit.
        /// </summary>
        /// <param name="number">Entered number</param>
        /// <param name="digit">Filtration digit</param>
        /// <returns>Return true if number contains specified digit and false if it isn't. </returns>
        bool IPredicate.Predicate(int number)
        {
            if (number < 0)
            {
                number = -number;
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
    }
}
