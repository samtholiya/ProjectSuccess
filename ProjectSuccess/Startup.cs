using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectSuccess.Startup))]
namespace ProjectSuccess
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
