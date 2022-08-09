using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Implementation.Extensions;

namespace Implementation.Classes
{
    [Serializable]
    public class Person : Prototype<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
        public override Person Clone()
        {
            MemoryStream stream = this.SerializeToStream();

            return (Person)stream.DeserializeFromStream();
        }
    }
}