using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactManagerCSharp.Startup))]
namespace ContactManagerCSharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
