using WebApplication_Pronia.Models.Base;

namespace WebApplication_Pronia.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<CategoryProduct> CategoryProducts { get; set; }
    }
}
