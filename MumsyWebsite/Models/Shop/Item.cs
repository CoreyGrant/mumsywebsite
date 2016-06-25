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
		public Dimensions Dimensions { get; set; }
		public ItemType Type { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public IEnumerable<KitContent> Contents { get; set; }
		public bool HasHalfStitches { get; set; }
		public IEnumerable<string> ExtraInformation { get; set; }
	}

	public enum ItemType 
	{
		Card = 0,
		Sampler = 1
	}

	public class Dimensions 
	{
		public decimal WidthInches { get; set; }
		public decimal WidthCentimeters { get; set; }
		public decimal HeightInches { get; set; }
		public decimal HeightCentimeters { get; set; }
	}
}