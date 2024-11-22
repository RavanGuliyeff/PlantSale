using WebApplication_Pronia.Models.Base;

namespace WebApplication_Pronia.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public List<ProductTag> ProductTags { get; set; }
    }
}
