using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MumsyWebsite.Startup))]
namespace MumsyWebsite
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
		}
	}
}
