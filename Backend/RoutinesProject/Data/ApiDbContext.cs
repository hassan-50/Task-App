using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoutinesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutinesProject.Data
{
    public class ApiDbContext : IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {
            SaveChangesFailed += ApiDbContext_SaveChangesFailed;
        }

     

        private void ApiDbContext_SaveChangesFailed(object sender, SaveChangesFailedEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
        }
        public DbSet<TaskReq> TaskReqs { get; set; }
    }
}
