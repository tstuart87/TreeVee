using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TreeVee.WebMVC.Startup))]
namespace TreeVee.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
