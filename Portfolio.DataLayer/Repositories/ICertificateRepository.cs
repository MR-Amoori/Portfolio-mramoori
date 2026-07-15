using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Repositories
{
    public interface ICertificateRepository
    {
        Certificate GetBy(int id);
        void Update(Certificate certificate);
        void Delete(int id);
        void Add(Certificate certificate);
        void Save();
    }
}
