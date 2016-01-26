using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Acme_Motors.Startup))]
namespace Acme_Motors
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
