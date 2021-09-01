using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutinesProject.Requests
{
    public class LoginResponse
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }
        public string RoLe { get; set; }

    }
}
