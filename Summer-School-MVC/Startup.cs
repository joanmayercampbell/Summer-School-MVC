using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Summer_School_MVC.Startup))]
namespace Summer_School_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
