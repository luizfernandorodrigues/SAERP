using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAERP.Startup))]
namespace SAERP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
