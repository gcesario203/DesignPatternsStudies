using Implementation.SystemUser.Interface;

namespace Implementation.SystemUser.DataObjects
{
    public class AdminAddress : IAddress
    {
        public string Street { get; set; }
        public int Number { get; set; }
    }
}