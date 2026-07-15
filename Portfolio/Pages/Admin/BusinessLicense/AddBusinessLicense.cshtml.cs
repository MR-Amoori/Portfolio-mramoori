using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Models;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.BusinessLicense
{
    [Authorize]
    public class AddBusinessLicenseModel : PageModel
    {
        private IBusinessLicenseRepository _repository;

        public AddBusinessLicenseModel(IBusinessLicenseRepository repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty] public DataLayer.Models.BusinessLicense BusinessLicense { get; set; }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repository.Add(BusinessLicense);

            return RedirectToPage("/Admin/Index");
        }
    }
}
