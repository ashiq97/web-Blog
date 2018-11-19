using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web_blog.Startup))]
namespace web_blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
