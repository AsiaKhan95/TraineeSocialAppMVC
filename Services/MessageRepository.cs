using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using TraineeSocialAppMVC.Services.Interface;

namespace TraineeSocialAppMVC.Services
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(SocialAppDBContext Context) : base(Context)
        {
        }
    }
}
