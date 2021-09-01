using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksFrontEnd.models;

namespace TasksFrontEnd.HttpRepository
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDto> RegisterUser(UserForRegistrationDto userForRegistration);
        Task<AuthResponseDto> Login(UserForAuthenticationDto userForAuthentication);
        Task Logout();
    }
}
