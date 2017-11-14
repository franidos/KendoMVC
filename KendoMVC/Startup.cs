using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KendoMVC.Startup))]
namespace KendoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
