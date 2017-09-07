using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaypalMVC.Startup))]
namespace PaypalMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
