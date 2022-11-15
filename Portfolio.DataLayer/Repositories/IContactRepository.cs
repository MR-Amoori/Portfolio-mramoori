using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Repositories
{
    public partial interface IContactRepository
    {
        void AddMessage(Contact contact);
        Contact GetBy(int id);
        void Delete(int id);
        void Save();
    }
}