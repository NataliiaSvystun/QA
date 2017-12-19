using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(taskQuestions.Startup))]
namespace taskQuestions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
