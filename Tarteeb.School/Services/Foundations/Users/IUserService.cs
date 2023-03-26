using System.Threading.Tasks;
using Tarteeb.School.Models.Users;

namespace Tarteeb.School.Services.Foundations.Users
{
    public interface IUserService
    {
        ValueTask<User> AddUserAsync(User user);
    }
}
