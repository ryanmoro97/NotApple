using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace part4.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string Name { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }
        public string Display { get; set; }
        public string Gpu { get; set; }
        public string OS { get; set; }
        public int Total { get; set; }

        public Order()
        {

        }
    }
}
