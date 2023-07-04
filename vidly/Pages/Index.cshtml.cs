using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vidly.Models;

namespace vidly.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService _productService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,JsonFileProductService jsonFileProductService)
        {
            _logger = logger;
            _productService = jsonFileProductService;
        }

        public void OnGet()
           {
            Products = _productService.GetProducts();

        }
    }
}