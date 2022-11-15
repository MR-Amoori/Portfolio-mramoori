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

namespace Portfolio.Pages.Admin.Personal
{
    public class EditPersonalModel : PageModel
    {
        private IPersonalRepository _repository;

        public EditPersonalModel(IPersonalRepository repository)
        {
            _repository = repository;
        }

        [BindProperty] public DataLayer.Models.Personal Personal { get; set; }

        public IActionResult OnGetAsync(int id = 0)
        {
            if (id == 0)
            {
                return NotFound();
            }

            Personal = _repository.GetBy(id);

            if (Personal == null)
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
                _repository.EditPersonal(Personal);
            }
            catch
            {
                return NotFound();
            }

            return RedirectToPage("Admin/Index");
        }
    }
}