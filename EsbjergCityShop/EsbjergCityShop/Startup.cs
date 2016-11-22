using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EsbjergCityShop.Startup))]
namespace EsbjergCityShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
