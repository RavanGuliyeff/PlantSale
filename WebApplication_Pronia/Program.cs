using Microsoft.EntityFrameworkCore;
using WebApplication_Pronia.DAL;

namespace WebApplication_Pronia
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();
			builder.Services.AddDbContext<AppDbContext>(opt =>
			{
				opt.UseSqlServer(builder.Configuration.GetConnectionString("default"));
			});



			var app = builder.Build();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=home}/{action=index}/{id?}"
				);

			app.UseStaticFiles();


			app.Run();
		}
	}
}
