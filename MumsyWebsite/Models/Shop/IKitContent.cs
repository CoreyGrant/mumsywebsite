using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MumsyWebsite.Models.Shop
{
	public interface IKitContent
	{
		string Name { get; set; }
		string Quantity { get; set; }
		string Details { get; set; }
	}
}