using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica1.UI.Startup))]
namespace Practica1.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
