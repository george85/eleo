using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eleo.Startup))]
namespace eleo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
