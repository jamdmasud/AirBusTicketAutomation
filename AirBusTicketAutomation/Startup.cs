using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AirBusTicketAutomation.Startup))]
namespace AirBusTicketAutomation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
