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
    public class CertificateRepository : ICertificateRepository
    {
        private PortfolioContext _context;

        public CertificateRepository(PortfolioContext context)
        {
            _context = context;
        }

        public Certificate GetBy(int id)
        {
            return _context.Certificates.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Certificate certificate)
        {
            _context.Certificates.Update(certificate);
            Save();
        }

        public void Delete(int id)
        {
            var entity = _context.Certificates.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _context.Certificates.Remove(entity);
                Save();
            }
        }

        public void Add(Certificate certificate)
        {
            _context.Certificates.Add(certificate);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
