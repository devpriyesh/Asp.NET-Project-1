using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200397594_app2.Startup))]
namespace _200397594_app2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
