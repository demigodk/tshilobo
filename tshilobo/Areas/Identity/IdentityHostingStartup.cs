using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using tshilobo.Areas.Identity.Data;
using tshilobo.Models;

[assembly: HostingStartup(typeof(tshilobo.Areas.Identity.IdentityHostingStartup))]
namespace tshilobo.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<tshiloboContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("tshiloboContextConnection")));

                services.AddDefaultIdentity<tshiloboUser>()
                    .AddEntityFrameworkStores<tshiloboContext>();
            });
        }
    }
}