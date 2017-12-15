using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Makeup.Startup))]
namespace Makeup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
