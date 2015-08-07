using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lawler.Startup))]
namespace lawler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
