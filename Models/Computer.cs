using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public class Computer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double BasePrice { get; set; }

        public string ImageURL { get; set; }

        public string BrandName { get; set; }

        public string Description { get; set; }
    }
}
