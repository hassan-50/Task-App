using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RoutinesProject.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RoutinesProject.Services
{
    public class JwtGenerator
    {
        private readonly SymmetricSecurityKey key;

        public JwtGenerator(IConfiguration configuration)
        {
            key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["secret_key"]));
        }

        public string GenerateJwt(AppUser user)
        {
            var claim = new List<Claim>
            {
                new Claim(type:"id",value:user.Id.ToString()),
                new Claim(type: "username",value: user.UserName),
                new Claim(type: "role",value :user.Role),
            };

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var descriptor = new SecurityTokenDescriptor
            {
                IssuedAt = DateTime.UtcNow,
                SigningCredentials = credentials,
                Subject = new ClaimsIdentity(claim),
                Expires = DateTime.UtcNow.AddMinutes(30),


            };
            var tokenHanlder = new JwtSecurityTokenHandler();
            var securityToken = tokenHanlder.CreateToken(descriptor);
            return tokenHanlder.WriteToken(securityToken);
        }
    }
    
}
