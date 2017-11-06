using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EquipmentMaster.Startup))]
namespace EquipmentMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
