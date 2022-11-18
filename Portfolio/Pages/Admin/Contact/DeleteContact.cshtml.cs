using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Contact
{
    [Authorize]
    public class DeleteContactModel : PageModel
    {
        private IContactRepository _repository;

        public DeleteContactModel(IContactRepository repository)
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
