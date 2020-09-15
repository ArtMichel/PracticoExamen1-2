using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TareaMVC2.Startup))]
namespace TareaMVC2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
