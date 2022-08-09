using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Implementation.Extensions
{
    public static class MemoryExtensions
    {
        public static MemoryStream SerializeToStream(this object objectType)
        {
            MemoryStream stream = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, objectType);
            return stream;
        }
        public static object DeserializeFromStream(this MemoryStream stream)
        {
            IFormatter formatter = new BinaryFormatter();
            stream.Seek(0, SeekOrigin.Begin);
            object returnObject = formatter.Deserialize(stream);
            return returnObject;
        }
    }
}