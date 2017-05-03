using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneDayProjectMvc.Startup))]
namespace OneDayProjectMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
