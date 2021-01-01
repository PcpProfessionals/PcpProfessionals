using BL.BusinessObjects;
using BL.Services.Interfaces;
using DAL.Repositories;
using System;

namespace BL.Services
{
    public class AuthService : IAuthService
    {
        private UserRepository _userRepo;

        public AuthService()
        {
            _userRepo = new UserRepository();
        }

        public UserBo AuthenticateUser(string userName, string password)
        {
            var userDetail = _userRepo.GetUser(userName);

            return userDetail.Password == password
                ? new UserBo { Username = userDetail.Username, Email = userDetail.Email, LastLogin = userDetail.LastLogin, isValid = userDetail.IsActive, Password = userDetail.Password }
                : throw new Exception("Password does not match");

        }

        public bool VerifyUsername(string userName)
        {
            return _userRepo.VerifyUserName(userName);
        }
    }
}
