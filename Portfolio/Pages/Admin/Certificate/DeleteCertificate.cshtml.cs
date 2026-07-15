using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Certificate
{
    [Authorize]
    public class DeleteCertificateModel : PageModel
    {
        private ICertificateRepository _repository;

        public DeleteCertificateModel(ICertificateRepository repository)
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
