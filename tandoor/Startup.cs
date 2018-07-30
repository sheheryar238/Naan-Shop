using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tandoor.Startup))]
namespace tandoor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
