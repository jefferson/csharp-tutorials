using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSocketApplication.Startup))]
namespace WebSocketApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
