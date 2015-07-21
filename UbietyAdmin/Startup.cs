using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UbietyAdmin.Startup))]
namespace UbietyAdmin
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
