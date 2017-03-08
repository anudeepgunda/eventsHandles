using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(V3EventManagement.Startup))]
namespace V3EventManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
