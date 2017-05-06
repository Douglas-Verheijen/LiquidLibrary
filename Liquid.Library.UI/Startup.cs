using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Liquid.Library.UI.Startup))]
namespace Liquid.Library.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
