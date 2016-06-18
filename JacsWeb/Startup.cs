using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JacsWeb.Startup))]
namespace JacsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
