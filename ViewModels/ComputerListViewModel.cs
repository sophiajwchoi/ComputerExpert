using ComputerExpert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.ViewModels
{
    public class ComputerListViewModel
    {
        public IEnumerable<Computer> Computers { get; set; }
    }
}
