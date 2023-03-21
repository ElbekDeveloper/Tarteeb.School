using System;

namespace Tarteeb.School.Services.Foundations.Users
{
    public class UserService : IUserService
    {
        public Guid GetLoggedInUserId() => Guid.NewGuid();
    }
}
