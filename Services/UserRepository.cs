using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using TraineeSocialAppMVC.Services.Interface;

namespace TraineeSocialAppMVC.Services
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SocialAppDBContext Context) : base(Context)
        {
        }

        public IEnumerable<User> GetUserWithAddress()
        {
            return Context.Users
                 .Include( c => c.Addresses)
                 .ToList();
        }
        public SocialAppDBContext Context {
            get {
                return Context as SocialAppDBContext;
            }
        }
    }
}
