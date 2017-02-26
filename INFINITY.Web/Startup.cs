using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(INFINITY.Startup))]
namespace INFINITY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
