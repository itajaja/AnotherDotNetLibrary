namespace Adnl.Manipulation.Cloning
{
    /// <summary>
    /// Supports deep cloning, which creates a new instance of a class with the same values as an existing instance, meaning that also the referenced objects are recursively cloned.
    /// </summary>
    public interface IDeepCloneable<out T>
    {
        /// <summary>
        /// Creates a new object that is a deep  copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a deep copy of this instance.
        /// </returns>
        T DeepClone();
    }
}
