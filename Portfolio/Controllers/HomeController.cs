using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Repositories;
using Portfolio.DataLayer.ViewModels;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        IIndexRepository _repository;

        private PortfolioContext _context;

        public HomeController(IIndexRepository repository, PortfolioContext context)
        {
            _repository = repository;
            _context = context;
        }

        public IActionResult Index()
        {
            IndexViewModel index = new  IndexViewModel();
            index = _repository.GetIndex();
            return View(index);
        }


        #region Error

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        #endregion
    }
}