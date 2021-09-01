using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksFrontEnd.HttpRepository;
using TasksFrontEnd.models;

namespace TasksFrontEnd.Pages
{
        public partial class Registration
        {
            private UserForRegistrationDto _userForRegistration = new UserForRegistrationDto();
            private RegistrationRequest __userForRegistration = new RegistrationRequest();
            [Inject]
            public IAuthenticationService AuthenticationService { get; set; }
            [Inject]
            public NavigationManager NavigationManager { get; set; }
            public bool ShowRegistrationErrors { get; set; }
             public string Error { get; set; }
        public async Task Register()
            {
            _userForRegistration.UserName = __userForRegistration.Username;
            _userForRegistration.Password = __userForRegistration.Password;
            if(__userForRegistration.type == 0)
            {
                _userForRegistration.Role = "Technical";
            }
            else
            {
                _userForRegistration.Role = "Business";
            }
            ShowRegistrationErrors = false;
                var result = await AuthenticationService.RegisterUser(_userForRegistration);
                if (!result.IsSuccessfulRegistration)
                {
                    Error = result.ErrorMessage;
                    ShowRegistrationErrors = true;
                }
                else
                {
                    NavigationManager.NavigateTo("/login");
                }
            }
        }
    }
