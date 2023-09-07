using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebQuanLyQuanCafe.Startup))]
namespace WebQuanLyQuanCafe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
