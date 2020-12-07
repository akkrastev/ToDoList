using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDoListApplication.Areas.Identity.Data;
using ToDoListApplication.Data;

[assembly: HostingStartup(typeof(ToDoListApplication.Areas.Identity.IdentityHostingStartup))]
namespace ToDoListApplication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ToDoListDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ToDoListDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<ToDoListDbContext>();
            });
        }
    }
}