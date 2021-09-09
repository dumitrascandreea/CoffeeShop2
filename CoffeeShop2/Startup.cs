using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoffeeShop2.Startup))]
namespace CoffeeShop2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
