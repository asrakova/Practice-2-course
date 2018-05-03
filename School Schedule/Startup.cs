using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(School_Schedule.Startup))]
namespace School_Schedule
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
