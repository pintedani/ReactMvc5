using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactMvc5.Startup))]
namespace ReactMvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
