using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Blog
{
    public class DeleteBlogModel : PageModel
    {
        private IBlogRepository _repository;

        public DeleteBlogModel(IBlogRepository repository)
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
