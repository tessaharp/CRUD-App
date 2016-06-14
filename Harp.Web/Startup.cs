using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Harp.Web.Startup))]
namespace Harp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
