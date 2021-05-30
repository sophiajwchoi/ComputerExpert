using Microsoft.AspNetCore.Mvc;
using ComputerExpert.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Component = ComputerExpert.Models.Component;

namespace ComputerExpert.ViewModels
{
    public class OrderViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Computer> Computers { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Component> ProcessorOps { get; set; }
        public IEnumerable<Component> MemoryOps { get; set; }
        public IEnumerable<Component> StorageOps { get; set; }
        public IEnumerable<Component> SoundCardOps { get; set; }
        public IEnumerable<Component> GraphicsOps { get; set; }

        public IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
