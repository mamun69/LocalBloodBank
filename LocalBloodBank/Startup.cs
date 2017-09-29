using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalBloodBank.Startup))]
namespace LocalBloodBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
