using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.PortfolioAd
{
    public class DeletePortfolioModel : PageModel
    {
        private IPortfolioRepository _repository;

        public DeletePortfolioModel(IPortfolioRepository repository)
        {
            _repository = repository;
        }

        public RedirectToPageResult OnGet(int id)
        {
            _repository.Delete(id);
            return RedirectToPage("/Admin/Index");
        }
    }
}
