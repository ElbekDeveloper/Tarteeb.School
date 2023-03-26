using System;

namespace Tarteeb.School.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public Guid? ManagerId { get; set; }
        public string Password { get; set; }
        public string IsActive { get; set; }
        public string IsVerififed { get; set; }
        public string GitHubUsername { get; set; }
        public string TelegramUsername { get; set; }
    }
}
