using System.Runtime.Serialization;

namespace Implementation.Classes
{
    public abstract class Prototype<TClass> : ISerializable
    {
        public abstract TClass Clone();

        public Prototype()
        {
            
        }
        public Prototype(SerializationInfo info, StreamingContext context)
        {
            var properties = this.GetType().GetProperties();

            foreach (var property in properties)
                this.GetType()?.GetProperty(property.Name)?.SetValue(this, info.GetValue(property.Name, property.PropertyType) ?? null);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            var properties = this.GetType().GetProperties();

            foreach (var property in properties)
                info.AddValue(property.Name, this.GetType()?.GetProperty(property.Name)?.GetValue(this) ?? null);
        }
    }
}