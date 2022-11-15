using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Models;
using Portfolio.DataLayer.Repositories;
using Portfolio.DataLayer.ViewModels;

namespace Portfolio.Pages.Admin
{
   // [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IIndexRepository _repository;
        public IndexViewModel viewIndex { get; set; }
        public List<DataLayer.Models.Contact> ContactsViewModel { get; set; }

        public IndexModel(IIndexRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            viewIndex = _repository.GetIndex();
            ContactsViewModel = _repository.GetContact();
        }

        public void OnGetAdminDashboard()
        {

        }
    }
}