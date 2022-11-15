using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Models;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Blog
{
    public class AddBlogModel : PageModel
    {
        private IBlogRepository _repository;

        public AddBlogModel(IBlogRepository repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty] public DataLayer.Models.Blog Blog { get; set; }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Blog.CreateDate = DateTime.Now;

            _repository.Add(Blog);

            return RedirectToPage("/Admin/Index");
        }
    }
}