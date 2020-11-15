using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication8.Controllers
{
    public class DownloadController : Controller
    {
        ILogger<DownloadController> _logger;
        public DownloadController(ILogger<DownloadController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetFile(string name,string path) {
            _logger.LogInformation(name);
            System.Console.WriteLine("========================" + name);
            return PhysicalFile(@"C:\Users\Y\source\repos\WebApplication8\WebApplication8\wwwroot\Files\kirillakulich@gmail.com\uploadedfile", "application/force-download", name);
        }
    }
}
