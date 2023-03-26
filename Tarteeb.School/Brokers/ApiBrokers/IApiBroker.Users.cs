using System.Threading.Tasks;
using Tarteeb.School.Models.Users;

namespace Tarteeb.School.Brokers.ApiBrokers
{
    public partial interface IApiBroker
    {
        ValueTask<User> PostUserAsync(User user);
    }
}
