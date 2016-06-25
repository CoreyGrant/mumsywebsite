using MumsyWebsite.Models.Shop;
using MumsyWebsite.Models.Shared;
using System.Linq;
using System.Web.Mvc;

namespace MumsyWebsite.Controllers
{
	public class ShopController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		
		public ActionResult Item(string id) 
		{
			return View(new Item
			{
				Name = "SOME ITEM OR SOMETHING",
				Dimensions = new Dimensions { 
					HeightInches = 6,
					WidthInches = 6,
					HeightCentimeters = 15,
					WidthCentimeters = 15
				},
				HasHalfStitches = false,
				Price = 4.99M,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
				Type = ItemType.Card,
				ExtraInformation = new [] {"I'm a nice person honest"},
				Contents = new [] {
					new KitContent { Type = KitContentType.Material, Text = "14 count Aida"},
					new KitContent { Type = KitContentType.Card, Text = "Best Quality White Tri-fold card"},
					new KitContent { Type = KitContentType.Thread, Text = "DMC Thread"},
					new KitContent { Type = KitContentType.Envelope, Text = "There is an envelope"},
					new KitContent { Type = KitContentType.Other, Text = "Needle size 26"},
				},
				Images = Enumerable.Empty<Image>()
			});
		}
	}
}