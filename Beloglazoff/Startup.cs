using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Beloglazoff.Startup))]
namespace Beloglazoff
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
