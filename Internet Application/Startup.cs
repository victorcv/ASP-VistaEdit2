using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Internet_Application.Startup))]
namespace Internet_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
