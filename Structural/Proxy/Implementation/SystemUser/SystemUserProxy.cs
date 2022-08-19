using Implementation.SystemUser.Interface;

namespace Implementation.SystemUser
{
    public class SystemUserProxy : ISystemUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private ISystemUser RealUser;

        private IEnumerable<IAddress> RealUserAddresses;
        
        public SystemUserProxy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public IEnumerable<IAddress> GetAddresses()
        {
            if(RealUser == null)
                RealUser = new AdminUser(FirstName, LastName);

            if(RealUserAddresses == null)
                RealUserAddresses = RealUser.GetAddresses();

            return RealUserAddresses;
        }
    }
}