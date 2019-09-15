using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hoteru.Startup))]
namespace Hoteru
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
