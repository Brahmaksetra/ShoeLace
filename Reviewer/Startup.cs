using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reviewer.Startup))]
namespace Reviewer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
