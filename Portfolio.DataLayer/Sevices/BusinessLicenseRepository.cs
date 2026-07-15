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
    public class BusinessLicenseRepository : IBusinessLicenseRepository
    {
        private PortfolioContext _context;

        public BusinessLicenseRepository(PortfolioContext context)
        {
            _context = context;
        }

        public BusinessLicense GetBy(int id)
        {
            return _context.BusinessLicenses.FirstOrDefault(x => x.Id == id);
        }

        public void Update(BusinessLicense businessLicense)
        {
            _context.BusinessLicenses.Update(businessLicense);
            Save();
        }

        public void Delete(int id)
        {
            var entity = _context.BusinessLicenses.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _context.BusinessLicenses.Remove(entity);
                Save();
            }
        }

        public void Add(BusinessLicense businessLicense)
        {
            _context.BusinessLicenses.Add(businessLicense);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
