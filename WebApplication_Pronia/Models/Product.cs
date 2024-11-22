using WebApplication_Pronia.Models.Base;

namespace WebApplication_Pronia.Models
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
		public string SKU { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public List<ProductImage> ProductImages { get; set; }
		public List<CategoryProduct> CategoryProducts { get; set; }
		public List<ProductTag> ProductTags { get; set; }
	}
}
