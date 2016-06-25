using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MicroBlog.Startup))]
namespace MicroBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
