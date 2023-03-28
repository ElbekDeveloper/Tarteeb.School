using System.Threading.Tasks;
using Tarteeb.School.Brokers.DateTimes;
using Tarteeb.School.Models.UserViews;
using Tarteeb.School.Services.Foundations.Users;

namespace Tarteeb.School.Services.Views.UserViews
{
    public class UserViewService : IUserViewService
    {
        private readonly IUserService userService;
        private readonly IDateTimeBroker dateTimeBroker;

        public UserViewService(IUserService userService, IDateTimeBroker dateTimeBroker)
        {
            this.userService = userService;
            this.dateTimeBroker = dateTimeBroker;
        }

        public ValueTask<UserView> AddUserAsync(UserView userView)
        {
            throw new System.NotImplementedException();
        }
    }
}
