using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RunSP.Startup))]
namespace RunSP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
