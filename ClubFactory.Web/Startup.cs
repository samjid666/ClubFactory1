using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClubFactory.Web.Startup))]
namespace ClubFactory.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
