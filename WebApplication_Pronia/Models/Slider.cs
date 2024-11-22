using WebApplication_Pronia.Models.Base;

namespace WebApplication_Pronia.Models
{
	public class Slider : BaseEntity
	{
		public string TitleUp { get; set; }
		public string TitleDown { get; set; }
		public string Description { get; set; }
		public string ImgUrl { get; set; }
	}
}
