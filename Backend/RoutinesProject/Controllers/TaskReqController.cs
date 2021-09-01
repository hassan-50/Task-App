using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoutinesProject.Data;
using RoutinesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutinesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskReqController : ControllerBase
    {
        ApiDbContext _ApiDbContext;
        public TaskReqController(ApiDbContext ApiDbContext)
        {
            _ApiDbContext = ApiDbContext;
        }
        [HttpPost("add")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> add(TaskReq TaskReq)
        {
            if (TaskReq.Title != null)
            {
                var id = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(a => a.Type == "id").Value);
                var us = await _ApiDbContext.Users.FirstOrDefaultAsync(s => s.Id == id);
                //var id = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(a => a.Type == "id").Value);
                //routine.AppUserId = id;
                if (us.Role != "Admin")
                {
                    return StatusCode(StatusCodes.Status401Unauthorized);
                }
                await _ApiDbContext.TaskReqs.AddAsync(TaskReq);
                var res = await _ApiDbContext.SaveChangesAsync() > 0;
                if (res)
                {
                    //RoutineResponse rs = new RoutineResponse();
                    //rs.id = routin.Entity.Id; rs.title = routin.Entity.Title;
                    return Ok("done");
                }
                return BadRequest("Server error");
            }
            else
            {
                return BadRequest("title is required");
            }
        }
        [HttpGet("get")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> get(string keyword)
        {
            var id = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(a => a.Type == "id").Value);
            var us = await _ApiDbContext.Users.FirstOrDefaultAsync(s => s.Id == id);
            var Routines = from Routine in _ApiDbContext.TaskReqs
                           where EF.Functions.Like(Routine.Title, "%" + keyword + "%")
                           orderby (Routine.Checked)
                           select new
                           {
                               Id = Routine.Id,
                               Title = Routine.Title,
                               text = Routine.Text,
                               Checked = Routine.Checked,
                               Comment = Routine.Comment,
                               FileUrl = Routine.FileUrl,
                               Type = Routine.Type,
                           };

            if(us.Role == "Technical")
            {
                return Ok(Routines.Where(x=> x.Type == 0));
            }
            else if (us.Role == "Business")
            {
                return Ok(Routines.Where(x => x.Type == 1));
            }
            return Ok(Routines);
        }
        [HttpDelete("delete/{id}")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> delete(int id)
        {
            var Task = await _ApiDbContext.TaskReqs.FindAsync(id);
            _ApiDbContext.TaskReqs.Remove(Task);

            var res = await _ApiDbContext.SaveChangesAsync() > 0;
            if (res)
            {
                return Ok("Deleted Successfully");
            }
            else
            {
                return BadRequest("something went wrong");
            }

        }
        [HttpPut("check/{taskId}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> check(int taskId , string s)
        {
            var Task = await _ApiDbContext.TaskReqs.FindAsync(taskId);
            //var id = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(a => a.Type == "id").Value);
            //var user = await _ApiDbContext.Users.FirstOrDefaultAsync(s => s.Id == id);
            //var routine = await _ApiDbContext.Routine.FirstOrDefaultAsync(s => s.Id == Todo.RoutineId);
            //if (routine.AppUserId != id && user.Role != "admin")
            //{
            //    return StatusCode(StatusCodes.Status401Unauthorized);
            //}
            Task.Checked = true;

            var res = await _ApiDbContext.SaveChangesAsync();

            if (res > 0)
                return Ok("Todo Checked Successfully");
            else
                return BadRequest("Something Went Wrong");
        }
        [HttpPut("addcomment/{taskId}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> addcomment(int taskId ,[FromBody] string comment)
        {
            var Task = await _ApiDbContext.TaskReqs.FindAsync(taskId);
            //var id = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(a => a.Type == "id").Value);
            //var user = await _ApiDbContext.Users.FirstOrDefaultAsync(s => s.Id == id);
            //var routine = await _ApiDbContext.Routine.FirstOrDefaultAsync(s => s.Id == Todo.RoutineId);
            //if (routine.AppUserId != id && user.Role != "admin")
            //{
            //    return StatusCode(StatusCodes.Status401Unauthorized);
            //}
            Task.Comment = comment;

            var res = await _ApiDbContext.SaveChangesAsync();

            if (res > 0)
                return Ok("Comment Added Successfully");
            else
                return BadRequest("Something Went Wrong");
        }
        [HttpPut("uncheck/{taskId}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> uncheck(int taskId)
        {
            var Task = await _ApiDbContext.TaskReqs.FindAsync(taskId);
            var id = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(a => a.Type == "id").Value);
            var user = _ApiDbContext.Users.FirstOrDefault(s => s.Id == id);
            //var routine = _ApiDbContext.Routine.FirstOrDefault(s => s.Id == Todo.RoutineId);
            //if (routine.AppUserId != id && user.Role != "admin")
            //{
            //    return StatusCode(StatusCodes.Status401Unauthorized);
            //}
            Task.Checked = false;

            var res = await _ApiDbContext.SaveChangesAsync() > 0;
            if (res)
                return Ok("Task UnChecked Successfully");
            else
                return BadRequest("Something Went Wrong");

        }
    }
}
