using Batu.Exam.SmartpulseInternship.DataAccesLayer;
using Batu.Exam.SmartpulseInternship.Entities.Entity;
using Batu.Exam.SmartpulseInternship.RepositoryLayer.Respository;
using Batu.Exam.SmartpulseInternship.ServicesLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartPulseWebApp.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SmartPulseWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private readonly IntraDayTradeHistoryAppService m_intraDayTradeHistoryAppService = new(new DALRepository(new IntraDayTradeHistoryRepository()));
        public IActionResult Index()
        {

            List<IntraDayTradeHistoryInfo> list = m_intraDayTradeHistoryAppService.GetDataApiServiceLayer().ToList();

            return View(list);
        }


    }
}
