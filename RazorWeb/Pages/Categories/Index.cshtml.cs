using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWeb.Data;
using RazorWeb.Models;

namespace RazorWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Category> Categories { get; set; }
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Categories = _db.Category;
            Console.WriteLine(Categories);
        }
    }
}
