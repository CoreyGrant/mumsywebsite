namespace MumsyWebsite.Models.Shop
{
	public class KitContent
	{
		public KitContentType Type { get; set; }
		public string Text { get; set; }
	}

	public enum KitContentType 
	{
		Material = 0,
		Thread = 1,
		Chart = 2,
		Card = 3,
		Envelope = 4,
		Embelishment = 5,
		Other = 6,
	}
}