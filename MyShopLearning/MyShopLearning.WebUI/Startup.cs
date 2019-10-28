using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopLearning.WebUI.Startup))]
namespace MyShopLearning.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
