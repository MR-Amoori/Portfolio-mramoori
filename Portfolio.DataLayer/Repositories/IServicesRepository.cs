using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Repositories
{
    public interface IServicesRepository
    {
        Service GetBy(int id);
        void Update(Service service);
        void Delete(int id);
        void AddService(Service service);
        void Save();
    }
}