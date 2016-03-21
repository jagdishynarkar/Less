using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LessLearning.Startup))]
namespace LessLearning
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
