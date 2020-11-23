using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaClinico.Startup))]
namespace SistemaClinico
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
