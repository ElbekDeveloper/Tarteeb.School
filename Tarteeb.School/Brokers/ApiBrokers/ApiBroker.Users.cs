using System.Threading.Tasks;
using Tarteeb.School.Models.Users;

namespace Tarteeb.School.Brokers.ApiBrokers
{
    public partial class ApiBroker
    {
        public async ValueTask<User> PostUserAsync(User user) =>
             await PostAsync<User>(relativeUrl: "api/Users", content: user);
    }
}
