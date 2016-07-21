using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JavascriptExamples.Startup))]
namespace JavascriptExamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
