using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientManagement.Startup))]
namespace ClientManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
