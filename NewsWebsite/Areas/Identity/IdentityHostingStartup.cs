using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewsWebsite.Areas.Identity.Data;
using NewsWebsite.Data;

[assembly: HostingStartup(typeof(NewsWebsite.Areas.Identity.IdentityHostingStartup))]
namespace NewsWebsite.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<NewsWebsiteContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("NewsWebsiteContextConnection")));

                services.AddDefaultIdentity<NewsWebsiteUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<NewsWebsiteContext>();
            });
        }
    }
}