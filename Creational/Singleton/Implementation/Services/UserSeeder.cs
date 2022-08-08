using System;
using System.Collections.Generic;
using Implementation.Models;
using Implementation.Utility;

namespace Implementation.Services
{
    public static class UserSeeder
    {
        private static Random random = new Random();
        public static List<User> BuildFakeUsers()
        {
            var numberOfUsers = random.Next(1,50);
            var result = new List<User>();

            for(var i = 0; i < numberOfUsers; i++)
                result.Add(new User(BuildRandomName(),BuildRandomName()));

            return result;
        }

        private static string BuildRandomName()
        {
            return StringUtils.RandomString(random.Next(1,9));
        }
    }
}