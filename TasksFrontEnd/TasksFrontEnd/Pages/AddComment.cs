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
    public partial class AddComment
    {
        private CommentDto _userComment = new CommentDto();
        private SuccessNotification _notification;

        [Parameter]
        public int Id { get; set; }
        [Inject]
        public ITaskHttpRepository AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public async Task AddCommente ()
        {
             await AuthenticationService.AddComment(Id,_userComment.Comment);
                       
            _notification.Show($"Comment Added Successfully!!");
                //NavigationManager.NavigateTo("/tasks");
        }
    }
}
