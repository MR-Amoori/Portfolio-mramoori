using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Repositories;

namespace Portfolio.DataLayer.Sevices
{
    public class PortfolioRepository : IPortfolioRepository
    {
        private PortfolioContext _context;

        public PortfolioRepository(PortfolioContext context)
        {
            _context = context;
        }

        public Models.Portfolio GetBy(int id)
        {
            return _context.Portfolios.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Models.Portfolio portfolio)
        {
            _context.Portfolios.Add(portfolio);
            Save();
        }

        public void Update(Models.Portfolio portfolio)
        {
            _context.Portfolios.Update(portfolio);
            Save();
        }

        public void Delete(int id)
        {
            _context.Portfolios.Remove(GetBy(id));
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
