using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CardioSence.Startup))]
namespace CardioSence
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
