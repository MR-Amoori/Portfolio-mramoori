using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Service
{
    public class DeleteServiceModel : PageModel
    {
        private IServicesRepository _repository;

        public DeleteServiceModel(IServicesRepository repository)
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
