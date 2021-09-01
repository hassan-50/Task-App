using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoutinesProject.Requests
{
    public class LoginRequests
    {
        [Required(ErrorMessage = "UserName is required.")]
        public string username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }
    }
}
