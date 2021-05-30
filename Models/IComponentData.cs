using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public interface IComponentData
    {
        IEnumerable<Component> GetProcessorOps { get; }
        IEnumerable<Component> GetGraphicsOps { get; }
        IEnumerable<Component> GetMemoryOps { get; }
        IEnumerable<Component> GetStorageOps { get; }
        IEnumerable<Component> GetSoundCardOps { get; }
        IEnumerable<Component> GetAllComponents { get; }
    }
}
