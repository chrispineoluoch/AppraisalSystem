using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppraisalSystem.Startup))]
namespace AppraisalSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
