using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NIIT.BookStore2.Web.Startup))]
namespace NIIT.BookStore2.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
