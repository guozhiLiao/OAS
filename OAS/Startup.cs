using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAS.Startup))]
namespace OAS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
