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
   public class ServicesRepository : IServicesRepository
   {
       private PortfolioContext _context;

       public ServicesRepository(PortfolioContext context)
       {
           _context = context;
       }

       public Service GetBy(int id)
       {
          return _context.Services.FirstOrDefault(x => x.Id == id);
       }

        public void Update(Service service)
        {
            _context.Services.Update(service);
            Save();
        }

        public void Delete(int id)
        {
            _context.Services.Remove(GetBy(id));
            Save();
        }

        public void AddService(Service service)
        {
            _context.Services.Add(service);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
