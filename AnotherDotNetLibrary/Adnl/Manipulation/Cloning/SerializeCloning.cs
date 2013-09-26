using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Adnl.Manipulation.Cloning
{
    /// <summary>
    /// Provides an extension method to deep clone the object using serialization methods. All the classes involved must be marked as [Serializable]
    /// </summary>
    public static class SerializeCloning
    {
        /// <summary>
        /// Creates a new object that is a deep  copy of the current instance using serialization mechanisms. All the classes involved must be marked as [Serializable].
        /// </summary>
        /// <returns>
        /// A new object that is a deep copy of this instance.
        /// </returns>
        public static T DeepClone<T>(this T a)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, a);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
