using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSoftTest.Startup))]
namespace WebSoftTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
