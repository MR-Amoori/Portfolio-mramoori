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

namespace Portfolio.Pages.Admin.Blog
{
    public class EditBlogModel : PageModel
    {
        private IBlogRepository _repository;

        public EditBlogModel(IBlogRepository repository)
        {
            _repository = repository;
        }

        [BindProperty] public DataLayer.Models.Blog Blog { get; set; }
        private DateTime date;

        public IActionResult OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog = _repository.GetBy(id.Value);

            if (Blog == null)
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
                _repository.Update(Blog);
            }
            catch
            {
                return NotFound();
            }

            return RedirectToPage("/Admin/Index");
        }
    }
}