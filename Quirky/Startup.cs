using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quirky.Startup))]
namespace Quirky
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
