using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ongconcordia.Startup))]
namespace ongconcordia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
