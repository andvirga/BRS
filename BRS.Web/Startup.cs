using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BRS.Web.Startup))]
namespace BRS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
