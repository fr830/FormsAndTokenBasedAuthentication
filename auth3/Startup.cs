using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(auth3.Startup))]
namespace auth3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
