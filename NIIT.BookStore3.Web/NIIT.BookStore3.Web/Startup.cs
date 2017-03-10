using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NIIT.BookStore3.Web.Startup))]
namespace NIIT.BookStore3.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
