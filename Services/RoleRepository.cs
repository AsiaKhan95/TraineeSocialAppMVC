using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using TraineeSocialAppMVC.Services.Interface;

namespace TraineeSocialAppMVC.Services
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(SocialAppDBContext context) : base(context)
        {
        }
    }
}
