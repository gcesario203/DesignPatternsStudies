using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Implementation.Extensions;

namespace Implementation.Classes
{
    [Serializable]
    public class Address : Prototype<Address>
    {
        public string Street { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Number { get; set; }

        public Address() { }
        public Address(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
        public override Address Clone()
        {
            MemoryStream stream = this.SerializeToStream();

            return (Address)stream.DeserializeFromStream();
        }
    }
}