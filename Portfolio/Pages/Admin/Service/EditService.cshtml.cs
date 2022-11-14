using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Models;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Service
{
    public class EditServiceModel : PageModel
    {
        private IServicesRepository _repository;

        public EditServiceModel(IServicesRepository repository)
        {
            _repository = repository;
        }

        [BindProperty] public DataLayer.Models.Service Service { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Service = _repository.GetBy(id.Value);

            if (Service == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            try
            {
                _repository.Update(Service);
            }
            catch
            {
                return NotFound();
            }

            return RedirectToPage("/Admin/Index");
        }
    }
}