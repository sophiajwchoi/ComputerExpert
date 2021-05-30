using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public class ComputerData : IComputerData
    {
        //private readonly IComponentData _componentData = new ComponentData();

        private readonly AppDbContext _appDbContext;

        public ComputerData(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Computer> GetAllComputers
        {
            get
            {
                return _appDbContext.Computers;
            }
        }
        //public IEnumerable<Computer> GetAllComputers => new List<Computer>
        //{

        //};
        //new Computer() { Id = 1, Name = "Legion Tower 7i Gaming Desktop", BasePrice = 4399.99, FinalPrice=4399.99, BrandName = "Legion", ImageURL = "~/imgs/lenovo-desktop-legion-tower-7i-hero.webp", ProcessorOps = _componentData.getProcessorOps.ToList(), Processor=_componentData.getProcessorOps.ToList()[0], GraphicsOps=_componentData.getGraphicsOps.ToList(), Graphics=_componentData.getGraphicsOps.ToList()[0], MemoryOps =_componentData.getMemoryOps.ToList(), Memory=_componentData.getMemoryOps.ToList()[0],StorageOps= _componentData.getStorageOps.ToList(), Storage=_componentData.getStorageOps.ToList()[0], SoundCardOps=_componentData.getSoundCardOps.ToList(), SoundCard = _componentData.getSoundCardOps.ToList()[0] },
        //new Computer() { Id = 2, Name = "M70t Tower", BasePrice = 3599.00, FinalPrice=3599.00, BrandName = "ThinkCentre", ImageURL = "~/imgs/lenovo-thinkcentre-m70t-subseries-hero.webp", ProcessorOps = _componentData.getProcessorOps.ToList(), Processor=_componentData.getProcessorOps.ToList()[0], GraphicsOps=_componentData.getGraphicsOps.ToList(), Graphics=_componentData.getGraphicsOps.ToList()[0], MemoryOps =_componentData.getMemoryOps.ToList(), Memory=_componentData.getMemoryOps.ToList()[0],StorageOps= _componentData.getStorageOps.ToList(), Storage=_componentData.getStorageOps.ToList()[0], SoundCardOps=_componentData.getSoundCardOps.ToList(), SoundCard = _componentData.getSoundCardOps.ToList()[0] },
        //new Computer() { Id = 3, Name = "Legion Tower 5i (AMD) Gaming Computer", BasePrice = 4329.99,  FinalPrice = 4329.99, BrandName = "Legion", ImageURL = "~/imgs/lenovo-legion-tower-5i-hero.webp", ProcessorOps = _componentData.getProcessorOps.ToList(), Processor=_componentData.getProcessorOps.ToList()[0], GraphicsOps=_componentData.getGraphicsOps.ToList(), Graphics=_componentData.getGraphicsOps.ToList()[0], MemoryOps =_componentData.getMemoryOps.ToList(), Memory=_componentData.getMemoryOps.ToList()[0],StorageOps= _componentData.getStorageOps.ToList(), Storage=_componentData.getStorageOps.ToList()[0], SoundCardOps=_componentData.getSoundCardOps.ToList(), SoundCard = _componentData.getSoundCardOps.ToList()[0] },
        //new Computer() { Id = 4, Name = "Creator 5i Desktop Tower", BasePrice = 4095.99,  FinalPrice =  4095.99, BrandName = "LenovoPRO", ImageURL = "~/imgs/lenovo-desktop-ideacentre-creator-5i-subseries-hero.webp", ProcessorOps = _componentData.getProcessorOps.ToList(), Processor=_componentData.getProcessorOps.ToList()[0], GraphicsOps=_componentData.getGraphicsOps.ToList(), Graphics=_componentData.getGraphicsOps.ToList()[0], MemoryOps =_componentData.getMemoryOps.ToList(), Memory=_componentData.getMemoryOps.ToList()[0],StorageOps= _componentData.getStorageOps.ToList(), Storage=_componentData.getStorageOps.ToList()[0], SoundCardOps=_componentData.getSoundCardOps.ToList(), SoundCard = _componentData.getSoundCardOps.ToList()[0]},
        //new Computer() { Id = 5, Name = "IdeaCentre 5 AMD Desktop Tower", BasePrice = 3605.99, FinalPrice = 3605.99,BrandName = "Legion", ImageURL = "~/imgs/lenovo-desktops-ideacentre-500series-5-hero.webp", ProcessorOps = _componentData.getProcessorOps.ToList(), Processor=_componentData.getProcessorOps.ToList()[0], GraphicsOps=_componentData.getGraphicsOps.ToList(), Graphics=_componentData.getGraphicsOps.ToList()[0], MemoryOps =_componentData.getMemoryOps.ToList(), Memory=_componentData.getMemoryOps.ToList()[0],StorageOps= _componentData.getStorageOps.ToList(), Storage=_componentData.getStorageOps.ToList()[0], SoundCardOps=_componentData.getSoundCardOps.ToList(), SoundCard = _componentData.getSoundCardOps.ToList()[0] }
        public Computer GetComputersById(int Id)
        {
            return _appDbContext.Computers.FirstOrDefault(c => c.Id == Id);
        }

    }
}
