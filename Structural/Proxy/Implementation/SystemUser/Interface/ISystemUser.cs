namespace Implementation.SystemUser.Interface
{
    public interface ISystemUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        IEnumerable<IAddress> GetAddresses();
    }
}