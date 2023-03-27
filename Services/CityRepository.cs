using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using TraineeSocialAppMVC.Services.Interface;

namespace TraineeSocialAppMVC.Services
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(SocialAppDBContext Context) : base(Context)
        {
        }
    }
}
