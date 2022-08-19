using Implementation.SystemUser.DataObjects;
using Implementation.SystemUser.Interface;

namespace Implementation.SystemUser
{
    public class AdminUser : ISystemUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<AdminAddress> Addresses { get; set; } = new List<AdminAddress>
                                                        {
                                                            new AdminAddress{
                                                                Number = 24,
                                                                Street = "Rua Mario Covas"
                                                            }
                                                        };

        public AdminUser(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName =lastName;
        }

        public IEnumerable<IAddress> GetAddresses()
        {
            Thread.Sleep(2000);
            return Addresses;
        }
    }
}