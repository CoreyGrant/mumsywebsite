using System;
using System.Collections.Generic;
using MumsyWebsite.Models.Shared;

namespace MumsyWebsite.Models.Shop
{
	public class Item
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public IEnumerable<Image> Images { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public IEnumerable<IKitContent> Contents { get; set; }
	}
}