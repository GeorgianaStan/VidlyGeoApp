using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyGeoApp.Startup))]
namespace VidlyGeoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
