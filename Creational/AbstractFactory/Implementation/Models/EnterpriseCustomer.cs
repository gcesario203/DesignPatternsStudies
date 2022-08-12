using Implementation.Interfaces;

namespace Implementation.Models
{
    public class EnterpriseCustomer : ICustomer
    {
        public string Name { get; set; }

        public EnterpriseCustomer(string name)
        {
            Name = name;
        }
    }
}