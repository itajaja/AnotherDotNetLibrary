namespace Adnl.Manipulation.Cloning
{
    /// <summary>
    /// Supports shallow cloning, which creates a new instance of a class with the same values as an existing instance, meaning that the cloned object references to the same object referenced by the  original object.
    /// </summary>
    public interface IShallowCloneable<out T>
    {
        /// <summary>
        /// Creates a new object that is a shallow  copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a shallow copy of this instance.
        /// </returns>
        T Clone();
    }
}
