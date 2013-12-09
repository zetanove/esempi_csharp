using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsApplication1.Startup))]
namespace WebFormsApplication1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
