using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace part4.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpu { get; set; }
        public string Cpu2 { get; set; }

        public string Ram { get; set; }
        public string Ram2 { get; set; }
        public string Ram3 { get; set; }
        public string Storage { get; set; }
        public string Storage2 { get; set; }
        public string Storage3 { get; set; }
        public string Display { get; set; }
        public string Display2 { get; set; }
        public string Gpu { get; set; }
        public string Gpu2 { get; set; }
        public string OS { get; set; }
        public string OS2 { get; set; }
        public string OS3 { get; set; }
        public int Total { get; set; }

        public Computer()
        {

        }
    }
}
