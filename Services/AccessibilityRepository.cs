using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using TraineeSocialAppMVC.Services.Interface;

namespace TraineeSocialAppMVC.Services
{
    public class AccessibilityRepository : Repository<Accessibility>, IAccessibilityRepository
    {
        public AccessibilityRepository(SocialAppDBContext Context) : base(Context)
        {
        }
    }
}
