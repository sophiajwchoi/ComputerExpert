using ComputerExpert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
        public IEnumerable<Computer> Computers { get; set; }
        public IEnumerable<Component> ProcessorOps { get; set; }
        public IEnumerable<Component> MemoryOps { get; set; }
        public IEnumerable<Component> StorageOps { get; set; }
        public IEnumerable<Component> SoundCardOps { get; set; }
        public IEnumerable<Component> GraphicsOps { get; set; }

    }
}
