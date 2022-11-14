using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Repositories
{
    public interface ISkillRepository
    {
        Skill GetSkillBy(int id);
        void EditSkill(Skill skill);
        void DeleteSkill(int id);
        void AddSkill(Skill skill);
        void Save();
    }
}