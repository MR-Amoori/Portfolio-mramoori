using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.BusinessLicense
{
    [Authorize]
    public class DeleteBusinessLicenseModel : PageModel
    {
        private IBusinessLicenseRepository _repository;

        public DeleteBusinessLicenseModel(IBusinessLicenseRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public int Id { get; set; }

        public IActionResult OnGet(int id)
        {
            Id = id;
            return Page();
        }

        public IActionResult OnPost()
        {
            _repository.Delete(Id);
            return RedirectToPage("/Admin/Index");
        }
    }
}
