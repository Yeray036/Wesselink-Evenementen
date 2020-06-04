using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wesselink_Evenementen.Areas.Identity.Data;
using Wesselink_Evenementen.Data;

[assembly: HostingStartup(typeof(Wesselink_Evenementen.Areas.Identity.IdentityHostingStartup))]
namespace Wesselink_Evenementen.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddDefaultIdentity<VerifiedDbLogin>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<AuthDbContext>();
            });
        }
    }
}