using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MartialArtClubAppSQL.Startup))]
namespace MartialArtClubAppSQL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
