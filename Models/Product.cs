using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double FinalPrice { get; set; }
        public int ComputerId {get; set;}
        public int ProcessorId { get; set; }
        public int GraphicsId { get; set; }
        public int MemoryId { get; set; }
        public int StorageId { get; set; }
        public int SoundCardId { get; set; }    
    }
}
