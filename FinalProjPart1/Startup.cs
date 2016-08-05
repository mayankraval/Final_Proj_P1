using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalProjPart1.Startup))]
namespace FinalProjPart1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
