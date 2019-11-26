using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VehicleDatabase.Startup))]
namespace VehicleDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
