using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MumsyWebsite.Models.Shop
{
	public class Basket
	{
		public IEnumerable<Item> Items { get; set; }
	}
}