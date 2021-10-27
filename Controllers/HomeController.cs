using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using part4.Data;
using part4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace part4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [ActivatorUtilitiesConstructor]
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Feedback()
        {
            return View();
        }
        public IActionResult FeedbackSubmitted()
        {
            return View();
        }

        public async Task<IActionResult> Computers(int ? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computer = await _context.Computer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computer == null)
            {
                return NotFound();
            }

            return View(computer);
        }

        [HttpPost]
        public ActionResult Purchased(Computer computer)
        {
            string name = computer.Name;
            int total = computer.Total;
            string cpu = computer.Cpu.Split(",")[0];
            string ram = computer.Ram.Split(",")[0];
            string storage = computer.Storage.Split(",")[0];
            string display = computer.Display.Split(",")[0];
            string gpu = computer.Gpu.Split(",")[0];
            string os = computer.OS;
            int cpuPrice = Int32.Parse(computer.Cpu.Split(",")[1]);
            int ramPrice = Int32.Parse(computer.Ram.Split(",")[1]);
            int storagePrice = Int32.Parse(computer.Storage.Split(",")[1]);
            int displayPrice = Int32.Parse(computer.Display.Split(",")[1]);
            int gpuPrice = Int32.Parse(computer.Gpu.Split(",")[1]);
            total += cpuPrice + ramPrice + storagePrice + displayPrice + gpuPrice;
            ViewBag.name = name;
            ViewBag.total = total;
            ViewBag.cpu = cpu;
            ViewBag.ram = ram;
            ViewBag.storage = storage;
            ViewBag.display = display;
            ViewBag.gpu = gpu;
            ViewBag.os = os;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
