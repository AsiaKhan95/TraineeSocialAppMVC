using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

namespace TraineeSocialAppMVC.Services.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetUserWithAddress();
    }
}
