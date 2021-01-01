using DAL.Context;
using DAL.Entities.Auth;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private PcpProfessionalContext _context;

        public UserRepository() 
        {
            _context = new PcpProfessionalContext();
        }


        public UserEntity GetUser(string userName)
        {
            return _context.Users.AsNoTracking().Where(u => u.Username == userName).FirstOrDefault();
        }

        public bool VerifyUserName(string userName)
        {
            return _context.Users.AsNoTracking().Any(x=>x.IsActive && x.ExpiryOn > DateTime.Now && x.Username == userName);
        }
    }
}
