using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Models;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Service
{
    public class AddServiceModel : PageModel
    {
        private IServicesRepository _repository;

        public AddServiceModel(IServicesRepository repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty] public DataLayer.Models.Service Service { get; set; }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repository.AddService(Service);

            return RedirectToPage("/Admin/Index");
        }
    }
}