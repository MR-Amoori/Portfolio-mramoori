using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Models;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.PortfolioAd
{
    [Authorize]
    public class EditPortfolioModel : PageModel
    {
        private IPortfolioRepository _repository;

        public EditPortfolioModel(IPortfolioRepository repository)
        {
            _repository = repository;
        }

        [BindProperty] public DataLayer.Models.Portfolio Portfolio { get; set; }

        public IActionResult OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Portfolio = _repository.GetBy(id.Value);

            if (Portfolio == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            try
            {
                _repository.Update(Portfolio);
            }
            catch
            {
                return NotFound();
            }

            return RedirectToPage("/Admin/Index");
        }
    }
}