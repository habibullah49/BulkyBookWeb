using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BulkyBookWeb.Startup))]
namespace BulkyBookWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
