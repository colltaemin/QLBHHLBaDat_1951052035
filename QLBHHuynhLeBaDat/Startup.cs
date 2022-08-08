using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLBHHuynhLeBaDat.Startup))]
namespace QLBHHuynhLeBaDat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
