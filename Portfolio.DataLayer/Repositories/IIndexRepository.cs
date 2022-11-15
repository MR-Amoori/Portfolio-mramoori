using System.Collections.Generic;
using Portfolio.DataLayer.Models;
using Portfolio.DataLayer.ViewModels;

namespace Portfolio.DataLayer.Repositories
{
    public interface IIndexRepository
    {
        IndexViewModel GetIndex();
        List<Contact> GetContact();
        void Save();
    }
}