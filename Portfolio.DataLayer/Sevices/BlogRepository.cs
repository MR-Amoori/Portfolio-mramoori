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
    public class BlogRepository : IBlogRepository
    {
        private PortfolioContext _context;

        public BlogRepository(PortfolioContext context)
        {
            _context = context;
        }

        public Blog GetBy(int id)
        {
            return _context.Blogs.Where(x => !x.IsDeleted).FirstOrDefault(x => x.Id == id);
        }

        public void Update(Blog blog)
        {
            _context.Blogs.Update(blog);
            Save();
        }

        public void Delete(int id)
        {
            _context.Blogs.FirstOrDefault(x => x.Id == id).IsDeleted = true;
            Save();
        }

        public void Add(Blog blog)
        {
            _context.Blogs.Add(blog);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
