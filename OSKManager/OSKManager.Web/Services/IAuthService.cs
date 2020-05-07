using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OSKManager.Api.Models;
using OSKManager.Model;
using OSKManager.Model.AuthenticationModels;

namespace OSKManager.Web.Services
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
