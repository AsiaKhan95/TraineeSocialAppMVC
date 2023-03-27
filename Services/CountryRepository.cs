using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using TraineeSocialAppMVC.Services.Interface;

namespace TraineeSocialAppMVC.Services
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(SocialAppDBContext Context) : base(Context)
        {
        }
    }
}
