using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica1.UI.Identity.Startup))]
namespace Practica1.UI.Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
