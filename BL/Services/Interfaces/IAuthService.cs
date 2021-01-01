using BL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Interfaces
{
    public interface IAuthService
    {
        bool VerifyUsername(string v);
        UserBo AuthenticateUser(string v1, string v2);
    }
}
