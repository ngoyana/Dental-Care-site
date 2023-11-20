using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dental_Care.Startup))]
namespace Dental_Care
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
