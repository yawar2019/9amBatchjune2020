using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BundlingExample.Startup))]
namespace BundlingExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
