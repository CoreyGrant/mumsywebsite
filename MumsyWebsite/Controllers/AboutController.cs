using System.Web.Mvc;
using MumsyWebsite.Helpers;

namespace MumsyWebsite.Controllers
{
	public class AboutController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[SubAction("Terms and Conditions")]
		public ActionResult Terms()
		{
			return View();
		}

		[SubAction("Satisfaction Guarantee")]
		public ActionResult Satisfaction()
		{
			return View();
		}

		[SubAction("FAQ")]
		public ActionResult Faq()
		{
			return View();
		}

		[SubAction("Postage and shipping")]
		public ActionResult Postage()
		{
			return View();
		}

		[SubAction]
		public ActionResult Returns()
		{
			return View();
		}
	}
}