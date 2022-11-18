using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Skill
{
    [Authorize]
    public class DeleteSkillModel : PageModel
    {
        private ISkillRepository _repository;

        public DeleteSkillModel(ISkillRepository repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet(int? id)
        {
            _repository.DeleteSkill(id.Value);
            return RedirectToPage("/Admin/Index");
        }
    }
}
