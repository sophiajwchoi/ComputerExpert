using Microsoft.AspNetCore.Mvc;
using ComputerExpert.Models;
using ComputerExpert.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Controllers
{
    public class HomeController : Controller
    {
        private readonly IComputerData _computerData;

        public HomeController(IComputerData computerData)
        {
            _computerData = computerData;
        }
        public IActionResult Index()
        {
            var computerListViewModel = new ComputerListViewModel();
            computerListViewModel.Computers = _computerData.GetAllComputers;

            return View(computerListViewModel);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Feedback()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
