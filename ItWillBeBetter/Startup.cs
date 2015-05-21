using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ItWillBeBetter.Startup))]
namespace ItWillBeBetter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
