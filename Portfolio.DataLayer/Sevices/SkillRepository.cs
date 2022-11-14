using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Models;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.DataLayer.Sevices
{
    public class SkillRepository : ISkillRepository
    {
        private readonly PortfolioContext _context;

        public SkillRepository(PortfolioContext context)
        {
            _context = context;
        }

        public Skill GetSkillBy(int id)
        {
            return _context.Skills.FirstOrDefault(x => x.Id == id);
        }

        public void EditSkill(Skill skill)
        {
            _context.Skills.Update(skill);
            Save();
        }

        public void DeleteSkill(int id)
        {
            _context.Skills.Remove(GetSkillBy(id));
            Save();
        }

        public void AddSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
