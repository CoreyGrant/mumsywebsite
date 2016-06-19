using System.Web.Mvc;
using MumsyWebsite.Models.Admin;

namespace MumsyWebsite.Controllers
{
	[Authorize]
	public class AdminController : Controller
	{
		[AllowAnonymous]
		public ActionResult Index()
		{
			return RedirectToAction("Login");
		}

		[HttpGet]
		[AllowAnonymous]
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(LoginModel model)
		{
			return RedirectToAction("Portal");
		}

		[HttpGet]
		public ActionResult Portal()
		{
			return View();
		}
	}
}