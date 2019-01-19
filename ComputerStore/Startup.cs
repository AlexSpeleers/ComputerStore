using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComputerStore.Startup))]
namespace ComputerStore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
