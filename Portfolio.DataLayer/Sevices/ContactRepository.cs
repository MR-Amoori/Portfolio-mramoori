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
    public class ContactRepository : IContactRepository
    {
        private readonly PortfolioContext _context;

        public ContactRepository(PortfolioContext context)
        {
            _context = context;
        }

        public void AddMessage(Contact contact)
        {
            _context.Contacts.Add(contact);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
