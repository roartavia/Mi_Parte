using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mi_Parte.Startup))]
namespace Mi_Parte
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
