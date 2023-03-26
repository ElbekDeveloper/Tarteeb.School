using System;

namespace Tarteeb.School.Models.UserViews
{
    public class UserView
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Password { get; set; }
        public string GitHubUsername { get; set; }
        public string TelegramUsername { get; set; }
    }
}
