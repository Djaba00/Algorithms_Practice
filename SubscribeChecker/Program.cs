using System;
namespace SubscribeChecker
{
    class Program
    {
        public static void Main()
        {
            List<User> users = new List<User>() { new User() { Login = "User1", Name = "Timofey", IsPremium = true },
            new User() { Login = "User2", Name = "Ivan", IsPremium = false },
            new User() { Login = "User3", Name = "Alexey", IsPremium = true },
            new User() { Login = "User4", Name = "Dmitry", IsPremium = true }};

            Authorization.Entrance(users);
        }
    }
}