using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Repositories
{
    public interface IBlogRepository
    {
        Blog GetBy(int id);
        void Update(Blog blog);
        void Delete(int id);
        void Add(Blog blog);
        void Save();
    }
}