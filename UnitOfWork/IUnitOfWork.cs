using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeSocialAppMVC.Services.Interface;

namespace TraineeSocialAppMVC.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IAccessibilityRepository Accessibilities { get; }
        IAddressRepository Addresss { get; }
        ICountryRepository Countries { get; }
        ICityRepository Cities { get; }
        IUserRepository Users { get; }
        IRoleRepository Roles { get; }
        IMessageRepository Messages { get; }
        IPhotoRepository Photos { get; }
        int Save();
    }
}
