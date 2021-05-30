using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public interface IComputerData
    {
        IEnumerable<Computer> GetAllComputers { get; }
        Computer GetComputersById(int Id);
    }
}
