using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Models;

namespace Portfolio.Pages.Admin.Skill
{
    public class AddSkillModel : PageModel
    {
        private readonly Portfolio.DataLayer.Context.PortfolioContext _context;

        public AddSkillModel(Portfolio.DataLayer.Context.PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DataLayer.Models.Skill Skill { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Skills.Add(Skill);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
