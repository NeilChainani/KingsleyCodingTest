using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KingsleyCodingTest.Startup))]
namespace KingsleyCodingTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
