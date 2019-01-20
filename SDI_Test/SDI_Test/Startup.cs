using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SDI_Test.Startup))]
namespace SDI_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
