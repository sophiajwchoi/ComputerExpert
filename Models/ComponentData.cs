using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public class ComponentData : IComponentData
    {
        private readonly AppDbContext _appDbContext;

        public ComponentData(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //public IEnumerable<Component> getProcessorOps => new List<Component>
        //{
        //    new Component() { Name = "i9-10901K", Price = 498, Id = 6, Type = "Processor" },
        //    new Component() { Type = "Processor", Price = 399.90, Id = 10, Name = "i7-10700KF" },
        //    new Component() { Type = "Processor", Price = 350.90, Id = 15, Name = "i3-10100" },
        //    new Component() { Name = "i3-10900K", Price = 125, Id = 16, Type = "Processor" },
        //    new Component() { Type = "Processor", Price = 143, Id = 20, Name = "i3-10300T" },
        //    new Component() { Name = "i9-10900K", Price = 488, Id = 21, Type = "Processor" },
        //    new Component() { Type = "Processor", Price = 195, Id = 25, Name = "i5-10500E" }

        //};

        //public IEnumerable<Component> getGraphicsOps => new List<Component>
        //{
        //    new Component() { Name = "NVIdIA GeForce RTX 3090", Price = 1499, Id = 2, Type = "Graphics" },
        //    new Component() { Name = "Nvidia GeForce RTX 3060 Ti", Price = 1599.90, Id = 7, Type = "Graphics" },
        //    new Component() { Name = "Nvidia GeForce RTX 3080", Price = 2740, Id = 12, Type = "Graphics" },
        //    new Component() { Name = "AMD Radeon RX 5600 XT", Price = 1195.10, Id = 17, Type = "Graphics" },
        //    new Component() { Name = "Nvidia GeForce RTX 3070", Price = 1899.90, Id = 22, Type = "Graphics" }
        //};

        //public IEnumerable<Component> getMemoryOps => new List<Component>
        //{
        //    new Component() { Type = "Memory", Price = 150, Id = 4, Name = "16GB DDR4-2933MHz, 2x8G" },
        //    new Component() { Type = "Memory", Price = 400, Id = 9, Name = "32GB DDR4-2933MHz, 2x16G" },
        //    new Component() { Type = "Memory", Price = 600.00, Id = 14, Name = "64GB DDR4-2933MHz, 2x32G" },
        //};

        //public IEnumerable<Component> getStorageOps => new List<Component>
        //{
        //    new Component() { Name = "512GB M.2 PCIe NVMe Solid State Drive", Price = 150, Id = 1, Type = "Storage" },
        //    new Component() { Name = "Seagate BarraCuda 2TB Internal Hard Drive HDD 3.5 Inch SATA 6Gb/s", Price = 64.99, Id = 3, Type = "Storage" },
        //    new Component() { Type = "Storage", Price = 799.99, Id = 5, Name = "1TB M.2 PCIe NVMe Solid State Drive" },
        //    new Component() { Name = "Crucial MX500 250GB 3D NAND SATA M.2", Price = 84.72, Id = 8, Type = "Storage" },
        //    new Component() { Name = "2TB M.2 PCIe NVMe Solid State Drive", Price = 600, Id = 11, Type = "Storage" },
        //    new Component() { Name = "Crucial MX500 500GB 3D NAND SATA M.2", Price = 82.5, Id = 13, Type = "Storage" },
        //    new Component() { Name = "Samsung 870 EVO 500GB SATA 2.5 Internal SSD", Price = 219.99, Id = 18, Type = "Storage" },
        //    new Component() { Type = "Storage", Price = 259.90, Id = 19, Name = "SAMSUNG 970 EVO PLUS M.2 2280 1TB" },
        //    new Component() { Name = "Samsung 860 EVO 500GB SATA 2.5", Price = 78.80, Id = 23, Type = "Storage" },
        //    new Component() { Type = "Storage", Price = 99.99, Id = 24, Name = "SAMSUNG 970 EVO PLUS M.2 2280 500GB" },
        //};

        //public IEnumerable<Component> getSoundCardOps => new List<Component>
        //{
        //     new Component() { Type = "SoundCard", Price = 100, Id = 26, Name = " Onboard Realtek ALC1220-VB HD Audio" },
        //     new Component() { Type = "SoundCard", Price = 141.85, Id = 27, Name = "External USB DAC: Micca OriGen G2" },
        //     new Component() { Type = "SoundCard", Price = 534.69, Id = 28, Name = " External USB DAC: JDS Labs Element II" }

        //};

        public IEnumerable<Component> GetProcessorOps
        {
            get
            {
                return _appDbContext.Components.Where(c => c.Type == "Processor");
            }
        }
        public IEnumerable<Component> GetGraphicsOps
        {
            get
            {
                return _appDbContext.Components.Where(c => c.Type == "Graphics");
            }
        }

        public IEnumerable<Component> GetMemoryOps
        {
            get
            {
                return _appDbContext.Components.Where(c => c.Type == "Memory");
            }
        }
        public IEnumerable<Component> GetStorageOps
        {
            get
            { return _appDbContext.Components.Where(c => c.Type == "Storage"); }
        }


        public IEnumerable<Component> GetSoundCardOps
        {
            get
            {
                return _appDbContext.Components.Where(c => c.Type == "SoundCard");
            }

        }

        public IEnumerable<Component> GetAllComponents
        {
            get
            {
                return _appDbContext.Components;
            }
        }
    }
}
