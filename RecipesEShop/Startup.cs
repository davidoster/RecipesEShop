using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipesEShop.Startup))]
namespace RecipesEShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
