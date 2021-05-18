using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(EnglishExamOnline.Backend.Areas.Identity.IdentityHostingStartup))]
namespace EnglishExamOnline.Backend.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}