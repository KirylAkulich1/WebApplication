using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.Data;
namespace WebApplication8.Controllers
{
    public class AdminController : Controller
    {
        
        public AdminController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
