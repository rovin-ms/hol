using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleCRM.UI.Startup))]
namespace SimpleCRM.UI
{
    // 222 remote master change

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // master
            ConfigureAuth(app);

            // DevSkim
           var hash = System.Security.Cryptography.MD5.Create();

        }
    }
}
