using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication8.Controllers
{
    public class RequestController : Controller
    {
        private readonly DataContext _context;
        public RequestController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var requests = _context.AddRequests.Include("To").Where(req => req.To.UserName.Equals(User.Identity.Name));
            return View(requests);
        }
        public IActionResult Allowed()
        {
            var folders = _context.AllowedFolders.Where(folder => folder.To.Equals(User.Identity.Name));
            return View(folders);
        }
    }
}
