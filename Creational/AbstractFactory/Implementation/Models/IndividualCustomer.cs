using Implementation.Interfaces;

namespace Implementation.Models
{
    public class IndividualCustomer : ICustomer
    {
        public string Name { get; set; }

        public IndividualCustomer(string name)
        {
            Name = name;
        }
    }
}