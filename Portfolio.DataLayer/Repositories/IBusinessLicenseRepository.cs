using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Repositories
{
    public interface IBusinessLicenseRepository
    {
        BusinessLicense GetBy(int id);
        void Update(BusinessLicense businessLicense);
        void Delete(int id);
        void Add(BusinessLicense businessLicense);
        void Save();
    }
}
