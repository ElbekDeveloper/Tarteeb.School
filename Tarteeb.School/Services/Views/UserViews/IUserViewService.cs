using System.Threading.Tasks;
using Tarteeb.School.Models.UserViews;

namespace Tarteeb.School.Services.Views.UserViews
{
    public interface IUserViewService
    {
        ValueTask<UserView> AddUserAsync(UserView userView);
    }
}