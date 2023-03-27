using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using TraineeSocialAppMVC.Services.Interface;

namespace TraineeSocialAppMVC.Services
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(SocialAppDBContext Context) : base(Context)
        {
        }
    }
}
