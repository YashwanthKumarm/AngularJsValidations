using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJsValidations.Startup))]
namespace AngularJsValidations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
