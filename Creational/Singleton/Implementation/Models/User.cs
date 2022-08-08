namespace Implementation.Models
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{this.FirstName} - {this.LastName}\n";
        }

        public override bool Equals(object? user)
        {
            if(user == null || this.GetType() != user?.GetType())
                return false;

            User userToCompare = (User)user;

            return userToCompare.FirstName == FirstName && userToCompare.LastName == LastName;
        }
    }
}