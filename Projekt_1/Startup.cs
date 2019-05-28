using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projekt_1.Startup))]
namespace Projekt_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
