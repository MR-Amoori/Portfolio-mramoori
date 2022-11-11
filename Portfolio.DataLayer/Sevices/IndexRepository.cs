using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Repositories;
using Portfolio.DataLayer.ViewModels;

namespace Portfolio.DataLayer.Sevices
{
    public class IndexRepository : IIndexRepository
    {
        private readonly PortfolioContext _context;

        public IndexRepository(PortfolioContext context)
        {
            _context = context;
        }

        public IndexViewModel GetIndex()
        {
            IndexViewModel index = new IndexViewModel();

            index.Personal = _context.Personal.FirstOrDefault();

            index.Blogs = _context.Blogs.Where(x => !x.IsDeleted).ToList();

            index.Portfolios = _context.Portfolios.ToList();

            index.Service = _context.Services.ToList();

            index.Skills = _context.Skills.ToList();


            return index;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}