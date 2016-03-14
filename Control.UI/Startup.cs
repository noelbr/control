using Microsoft.Owin;
using Owin;
using System.IO;

[assembly: OwinStartupAttribute(typeof(Control.UI.Startup))]
namespace Control.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            string tempDirectory = Path.Combine(Path.GetTempPath(), "Timestamp");
            Directory.CreateDirectory(tempDirectory);

        }
    }
}