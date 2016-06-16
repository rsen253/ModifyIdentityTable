using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentiyTest.Startup))]
namespace IdentiyTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
