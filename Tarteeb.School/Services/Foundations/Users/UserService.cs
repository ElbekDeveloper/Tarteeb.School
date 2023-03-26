using System;
using System.Threading.Tasks;
using Tarteeb.School.Brokers.ApiBrokers;
using Tarteeb.School.Models.Users;

namespace Tarteeb.School.Services.Foundations.Users
{
    public class UserService : IUserService
    {
        private readonly IApiBroker apiBroker;

        public UserService(IApiBroker apiBroker) =>
            this.apiBroker = apiBroker;

        public async ValueTask<User> AddUserAsync(User user) =>
            await this.apiBroker.PostUserAsync(user);

        public Guid GetLoggedInUserId() => Guid.NewGuid();
    }
}
