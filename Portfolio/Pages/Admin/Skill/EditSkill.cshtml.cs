using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Models;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Skill
{
    [Authorize]
    public class EditSkillModel : PageModel
    {
        private ISkillRepository _repository;

        public EditSkillModel(ISkillRepository repository)
        {
            _repository = repository;
        }

        [BindProperty] public DataLayer.Models.Skill Skill { get; set; }

        public IActionResult OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Skill = _repository.GetSkillBy(id.Value);

            if (Skill == null)
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
                _repository.EditSkill(Skill);
            }
            catch
            {
                return NotFound();
            }

            return RedirectToPage("/Admin/Index");
        }
    }
}