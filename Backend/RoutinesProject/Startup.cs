using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using RoutinesProject.Data;
using RoutinesProject.Models;
using RoutinesProject.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RoutinesProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RoutinesProject", Version = "v1" });
            });
            services.AddDbContext<Data.ApiDbContext>(a => a.UseSqlServer(@"Data Source=DESKTOP-8MBB91F\SQLEXPRESS;Initial Catalog=TasksDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            services.AddCors();
            services.AddAuthentication(
             CertificateAuthenticationDefaults.AuthenticationScheme)
            .AddCertificate(); 

            services.AddScoped<JwtGenerator>();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["secret_key"]));

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    IssuerSigningKey = key,
                    SaveSigninToken = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
                opt.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var token = context.Request.Cookies.TryGetValue("accessToken", out string jwt);
                        if (token)
                        {
                            context.Token = jwt;
                        }
                        return Task.CompletedTask;
                    }
                };
            });

            var identity = services.AddIdentity<AppUser, IdentityRole<int>>(options =>
            {
                var passwordManager = options.Password;
                passwordManager.RequireDigit = false;
                passwordManager.RequireLowercase = false;
                passwordManager.RequireNonAlphanumeric = false;
                passwordManager.RequireUppercase = false;
            });

            var identityBuilder = new IdentityBuilder(identity.UserType, typeof(IdentityRole<int>), identity.Services);
            identityBuilder.AddEntityFrameworkStores<ApiDbContext>();
            identityBuilder.AddUserManager<UserManager<AppUser>>();
            identityBuilder.AddSignInManager<SignInManager<AppUser>>();
            identityBuilder.AddRoleValidator<RoleValidator<IdentityRole<int>>>();
            identityBuilder.AddRoleManager<RoleManager<IdentityRole<int>>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RoutinesProject v1"));
            }

            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"StaticFiles")),
                RequestPath = new PathString("/StaticFiles")
            });

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseCors(options => options
            .WithOrigins("http://localhost:5000")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials()                                               
            );

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
