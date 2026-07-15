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

        public IActionResult OnPost(int id)
        {
            _repository.Delete(id);
            return RedirectToPage("/Admin/Index");
        }
    }
}
