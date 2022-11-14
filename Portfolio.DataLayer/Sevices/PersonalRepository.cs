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
    public class PersonalRepository : IPersonalRepository
    {
        private readonly PortfolioContext _context;

        public PersonalRepository(PortfolioContext context)
        {
            _context = context;
        }

        public Personal GetBy(int id)
        {
            return _context.Personal.FirstOrDefault(x => x.Id == id);
        }

        public void EditPersonal(Personal personal)
        {
            _context.Personal.Update(personal);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}