using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QH.Startup))]
namespace QH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
