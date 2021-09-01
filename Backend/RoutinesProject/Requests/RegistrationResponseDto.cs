using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutinesProject.Requests
{
    public class RegistrationResponseDto
    {
        public bool IsSuccessfulRegistration { get; set; }
        public string ErrorMessage { get; set; }
    }
}
