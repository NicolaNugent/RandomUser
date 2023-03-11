using RandomUser.Models;

namespace RandomUser.App.Services
{
    public interface IUserService
    {
        Task<(List<User>, string)> GetRandom5Users();
    }
}
