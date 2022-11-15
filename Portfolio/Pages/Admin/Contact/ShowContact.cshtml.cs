using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Models;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Contact
{
    public class ShowContactModel : PageModel
    {
        private IContactRepository _repository;

        public ShowContactModel(IContactRepository repository)
        {
            _repository = repository;
        }

        public DataLayer.Models.Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = _repository.GetBy(id.Value);

            if (Contact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
