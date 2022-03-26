using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalCine.Startup))]
namespace FinalCine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
