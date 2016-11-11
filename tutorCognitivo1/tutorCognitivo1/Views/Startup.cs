using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tutorCognitivo1.Startup))]
namespace tutorCognitivo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
