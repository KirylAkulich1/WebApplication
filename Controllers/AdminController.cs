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
        private readonly DataContext _context;
        private readonly ApplicationDbContext _userctx;
        public AdminController(DataContext context,ApplicationDbContext usercontext)
        {
            _context = context;
            _userctx = usercontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Blank()
        {
            return View();
        }
        public IActionResult Report()
        {
            return View();
        }
        public IActionResult Reports(int id)
        {

            return View(_context.Reports);
        }
    }
}
