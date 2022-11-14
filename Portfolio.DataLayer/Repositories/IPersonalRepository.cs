using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Repositories
{
    public interface IPersonalRepository
    {
        Personal GetBy(int id);
        void EditPersonal(Personal personal);
        void Save();
    }
}