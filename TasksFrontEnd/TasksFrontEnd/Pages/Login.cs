using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksFrontEnd.HttpRepository;
using TasksFrontEnd.models;
using TasksFrontEnd.Shared;

namespace TasksFrontEnd.Pages
{
    public partial class Login
    {
        private SuccessNotification _notification;
        private UserForAuthenticationDto _userForAuthentication = new UserForAuthenticationDto();
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public bool ShowAuthError { get; set; }
        public string Error { get; set; }
        public async Task ExecuteLogin()
        {
            ShowAuthError = false;
            var result = await AuthenticationService.Login(_userForAuthentication);
            if (!result.IsAuthSuccessful)
            {
                Console.WriteLine(result);
                Error = result.ErrorMessage;
                ShowAuthError = true;
            }
            else
            {
                _notification.Show($"Welcome Back!!{_userForAuthentication.username}");
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
