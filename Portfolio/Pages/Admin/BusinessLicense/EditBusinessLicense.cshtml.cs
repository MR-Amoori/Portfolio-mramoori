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

namespace Portfolio.Pages.Admin.BusinessLicense
{
    [Authorize]
    public class EditBusinessLicenseModel : PageModel
    {
        private IBusinessLicenseRepository _repository;

        public EditBusinessLicenseModel(IBusinessLicenseRepository repository)
        {
            _repository = repository;
        }

        [BindProperty] public DataLayer.Models.BusinessLicense BusinessLicense { get; set; }

        public IActionResult OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BusinessLicense = _repository.GetBy(id.Value);

            if (BusinessLicense == null)
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
                _repository.Update(BusinessLicense);
            }
            catch
            {
                return NotFound();
            }

            return RedirectToPage("/Admin/Index");
        }
    }
}
