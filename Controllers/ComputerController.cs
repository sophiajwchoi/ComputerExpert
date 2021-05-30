using Microsoft.AspNetCore.Mvc;
using ComputerExpert.Models;
using ComputerExpert.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Controllers
{
    public class ComputerController : Controller
    {
        private readonly IComputerData _computerData;
        private readonly IComponentData _componentData;

        public ComputerController(IComputerData computerData, IComponentData componentData)
        {
            _componentData = componentData;
            _computerData = computerData;
        }

        public IActionResult List()
        {
            //return View(_computerData.GetAllComputers);
            var computerListViewModel = new ComputerListViewModel();
            computerListViewModel.Computers = _computerData.GetAllComputers;

            return View(computerListViewModel);
        }

        public IActionResult Details(int id)
        {
            var computerDetailViewModel = new DetailViewModel();
            var computer = _computerData.GetComputersById(id);
            var processorOps = _componentData.GetProcessorOps;
            var memoryOps = _componentData.GetMemoryOps;
            var graphicsOps = _componentData.GetGraphicsOps;
            var soundCartOps = _componentData.GetSoundCardOps;
            var storageOps = _componentData.GetStorageOps;
            computerDetailViewModel.ProcessorOps = processorOps;
            computerDetailViewModel.Computer = computer;
            computerDetailViewModel.MemoryOps = memoryOps;
            computerDetailViewModel.GraphicsOps = graphicsOps;
            computerDetailViewModel.SoundCardOps = soundCartOps;
            computerDetailViewModel.StorageOps = storageOps;


            if (computer == null)
            {
                return NotFound();
            }
            return View(computerDetailViewModel);
        }
    }
}
