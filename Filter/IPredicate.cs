namespace Filter
{
    /// <summary>
    /// Gives for user the interface of interactions.
    /// </summary>
    public interface IPredicate
    {
        /// <summary>
        /// Gets a number and returns bool result. 
        /// </summary>
        /// <param name="number">Number.</param>
        /// <returns>True/false.</returns>
        bool Predicate(int number);
    }
}
