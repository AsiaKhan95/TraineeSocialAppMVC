using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeSocialAppMVC.Services;
using TraineeSocialAppMVC.Services.Interface;

namespace TraineeSocialAppMVC.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SocialAppDBContext _context;
        public UnitOfWork(SocialAppDBContext context)
        {
            _context = context;
            Accessibilities = new AccessibilityRepository(_context);
            Addresss = new AddressRepository(_context);
            Countries = new CountryRepository(_context);
            Cities = new CityRepository(context);
            Users= new UserRepository(_context);
            Roles= new RoleRepository(_context);
            Messages = new MessageRepository(_context);
            Photos= new PhotoRepository(context);

        }

        public IAccessibilityRepository Accessibilities { get; private set; }

        public IAddressRepository Addresss { get; private set; }

        public ICountryRepository Countries { get; private set; }

        public ICityRepository Cities { get; private set; }

        public IUserRepository Users { get; private set; }

        public IRoleRepository Roles { get; private set; }

        public IMessageRepository Messages { get; private set; }

        public IPhotoRepository Photos { get; private set; }



        public int Save()
        {
          return _context.SaveChanges();
        }
        public void Dispose() {
            _context.Dispose();
        }
       
    }
}
