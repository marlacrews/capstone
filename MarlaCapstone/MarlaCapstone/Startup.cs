using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarlaCapstone.Startup))]
namespace MarlaCapstone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
