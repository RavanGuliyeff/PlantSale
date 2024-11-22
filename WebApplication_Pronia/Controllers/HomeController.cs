using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_Pronia.DAL;
using WebApplication_Pronia.Models;
using WebApplication_Pronia.ViewModels;

namespace WebApplication_Pronia.Controllers
{
	public class HomeController : Controller
	{
		AppDbContext _db;

		public HomeController(AppDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			List<Slider> sliderList = _db.Sliders.ToList();
			List<Product> productList = _db.Products.Include(p => p.ProductImages).ToList();

			HomeVm Vm = new HomeVm()
			{
				Sliders = sliderList,
				Products = productList
			};

			return View(Vm);
		}

		public async Task<IActionResult> Detail(int? id)
		{
			if (id == null) return NotFound();

			var product = await _db.Products.Include(p => p.CategoryProducts).ThenInclude(tp => tp.Category)
				.Include(p => p.ProductTags).ThenInclude(tp => tp.Tag)
				.Include(p => p.ProductImages)
			.FirstOrDefaultAsync(p => p.Id == id);


			return View(product);
		}

	}
}
