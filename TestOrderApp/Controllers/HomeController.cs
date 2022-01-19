using BuissnesLayer;
using BuissnesLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestOrderApp.Models;
using ViewLayer;
using ViewLayer.Models;

namespace TestOrderApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private DataManager _dataManager;
        private ServicesManager _servicesManager;
        private IOrderRepository _orderRepository;



        public HomeController(ILogger<HomeController> logger, DataManager dataManager)
        {
            _dataManager = dataManager;
            _logger = logger;
            _servicesManager = new ServicesManager(_dataManager);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public string Index(NewOrderViewModel newOrderVM)
        {
            _servicesManager.Order.SaveOrderModelToDB(newOrderVM);
            return "Спасибо за покупку!";

            //return RedirectToAction("Index"/*, "Page", new { pageId = newOrderVM.Id, pageType = PageType.Directory }*/);
        }

    }
}