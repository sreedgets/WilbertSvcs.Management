using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WilbertFSvcs.Web.Data;

[assembly: HostingStartup(typeof(WilbertFSvcs.Web.Areas.Identity.IdentityHostingStartup))]
namespace WilbertFSvcs.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<WilbertFSvcsWebContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("WilbertFSvcsWebContextConnection")));

            //    services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //        .AddEntityFrameworkStores<WilbertFSvcsWebContext>();
            //});
        }
    }
}