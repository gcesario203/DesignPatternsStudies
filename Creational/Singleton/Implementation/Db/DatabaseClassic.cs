using Implementation.Models;
using Implementation.Services;
using System;
using System.Collections.Generic;

namespace Implementation.Db
{
    public class DatabaseClassic
    {
        public Guid Id { get; private set; }

        public List<User> Users { get; private set; }
        private static DatabaseClassic _instance;

        public static DatabaseClassic Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseClassic();

                return _instance;
            }
        }
        private DatabaseClassic()
        {
            Id = Guid.NewGuid();
            Users = UserSeeder.BuildFakeUsers();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public User RemoveRandomUser()
        {
            var random = new Random().Next(0, this.Users.Count - 1);

            var removedUser = Users[random];

            if(removedUser != null)
                Users.Remove(removedUser);

            return removedUser;
        }

        public override string ToString()
        {
            var returnString = "";
            foreach (var user in Users)
                returnString += user.ToString();

            return returnString;
        }
    }
}