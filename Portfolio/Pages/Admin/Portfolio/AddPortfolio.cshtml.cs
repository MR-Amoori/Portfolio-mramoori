using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Portfolio
{
    public class AddPortfolioModel : PageModel
    {
        private IPortfolioRepository _repository;

        public AddPortfolioModel(IPortfolioRepository repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DataLayer.Models.Portfolio Portfolio { get; set; }

        public async Task<IActionResult> OnPostAsync(IFormCollection form)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           _repository.AddPortfolio(Portfolio);

            return RedirectToPage("/Admin/Index");
        }
    }
}
