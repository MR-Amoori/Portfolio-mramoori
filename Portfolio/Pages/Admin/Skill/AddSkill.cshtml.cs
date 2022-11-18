using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.Pages.Admin.Skill
{
    //  [Authorize(Policy = "Admin")]
    [Authorize]
    public class AddSkillModel : PageModel
    {
        private ISkillRepository _repository;

        public AddSkillModel(ISkillRepository repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty] public DataLayer.Models.Skill Skill { get; set; }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repository.AddSkill(Skill);

            return RedirectToPage("/Admin/Index");
        }
    }
}