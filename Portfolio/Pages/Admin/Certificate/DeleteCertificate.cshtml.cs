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
