using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResterauntRaterMVC.Startup))]
namespace ResterauntRaterMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
