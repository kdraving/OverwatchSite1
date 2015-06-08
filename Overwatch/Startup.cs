using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Overwatch.Startup))]
namespace Overwatch
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
