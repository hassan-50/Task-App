using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoutinesProject.Data;
using RoutinesProject.Models;
using RoutinesProject.Requests;
using RoutinesProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RoutinesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ApiDbContext _ApiDbContext;
        private readonly UserManager<AppUser> userManager;
        private readonly JwtGenerator jwt;

        public UserController(ApiDbContext ApiDbContext,UserManager<AppUser> userManager,JwtGenerator jwt)
        {
            _ApiDbContext = ApiDbContext;
            this.userManager = userManager;
            this.jwt = jwt;
        }
        [HttpPost("register")]
        public async Task<IActionResult> register(RegisterRequest rr)
        {
            if (rr.Role == null)
                rr.Role = "user";
            var user = await _ApiDbContext.Users.FirstOrDefaultAsync(a => a.UserName == rr.UserName);
            if(user is not null)
            {
                return BadRequest(new LoginResponse { ErrorMessage = "UserName is Already Exists" });
            }
            user = new AppUser
            {
                FirstName = rr.FirstName,
                LastName = rr.LastName,
                UserName = rr.UserName,
                Role = rr.Role
            };
            
            var result =await userManager.CreateAsync(user, rr.Password);
            if (result.Succeeded)
            {
                var token = jwt.GenerateJwt(user);
                HttpContext.Response.Cookies.Append("accessToken", token, new CookieOptions() { HttpOnly = true }) ;
                LoginResponse lR = new LoginResponse();
                //lR.username = user.UserName; lR.firstname = user.FirstName; lR.lastname = user.LastName; lR.token = token; lR.role = user.Role;
                //await userManager.AddToRoleAsync(user, "Viewer");
                return Ok();
            }
            else
            {
               return BadRequest(new LoginResponse { ErrorMessage = "Server Error" });
            }
        }
        [HttpPost("login")]
        public async Task<IActionResult> login(LoginRequests rr)
        {
            var user = await _ApiDbContext.Users.FirstOrDefaultAsync(a => a.UserName == rr.username);
            if (user is null)
            {
                return Unauthorized(new LoginResponse { ErrorMessage = "Invalid Authentication" });
            }

            var result = await userManager.CheckPasswordAsync(user, rr.password);
            if (result)
            {
                var token = jwt.GenerateJwt(user);
                HttpContext.Response.Cookies.Append("accessToken", token, new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(7),
                    HttpOnly = true,
                    Secure = false
                });
                //LoginResponse lR = new LoginResponse();
                //lR.username = user.UserName;lR.firstname = user.FirstName; lR.lastname = user.LastName;lR.token = token;lR.role = user.Role;
                return Ok(new LoginResponse { IsAuthSuccessful = true, Token = token , RoLe = user.Role});
            }
            else
            {
                return Unauthorized(new LoginResponse { ErrorMessage = "Invalid Authentication" });
            }
        }
        [HttpGet("get")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> get()
        {
            var id = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(a => a.Type == "id").Value);
            var us =await  _ApiDbContext.Users.FirstOrDefaultAsync(s => s.Id == id);
            if(us.Role != "Admin")
            {
                return StatusCode(StatusCodes.Status401Unauthorized);
            }
            var users = await _ApiDbContext.Users.Select(s=> new { id = s.Id, firstname = s.FirstName, lastname = s.LastName, username = s.UserName, role= s.Role}).ToListAsync();
            if (users is null)
         return BadRequest("Something Went Wrong");
            
            if (users is not null)
            {                               
                return Ok(users);
            }
            else
            {
                return BadRequest("Something Went Wrong");
            }
        }
        [HttpPost("logout")]
        public async Task<IActionResult> logout()
        {
            HttpContext.Response.Cookies.Delete("accessToken");
            return Ok(new { 
            message = "success"
            });
        }

        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult>  delete(int id)
        {
            var user = await _ApiDbContext.Users.FindAsync(id);
            _ApiDbContext.Users.Remove(user);
            var res = await _ApiDbContext.SaveChangesAsync() > 0;
            if (res)
            {
                return Ok("User Deleted Successfully");
            }
            else
            {
                return BadRequest("Something Went Wrong");
            }
        
        }        
    }
}
