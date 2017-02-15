using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DDDAngular.Startup))]
namespace DDDAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
