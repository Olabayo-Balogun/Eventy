using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eventy.Startup))]

namespace Eventy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}