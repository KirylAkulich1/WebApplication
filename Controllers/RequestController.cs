using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class RequestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequestController(ApplicationDbContext ctx)
        {
            _context = ctx;
            
        }
        public IActionResult Index()
        {
            var curUser = _context.Users.First(p => p.UserName== User.Identity.Name);
            var requests = _context.AddRequests
                .Where(req => req.ToId==curUser.Id)
                .Include(req=>req.From)
                .Include(req=>req.Folder);
            return View(requests);
        }
        public IActionResult SendedRequests()
        {
            var requests = _context.AddRequests.Where(req => req.From.Equals(User.Identity.Name)).Include(p=>p.Folder).Include(p=>p.From);
            return View(requests);
        }
        public IActionResult Allowed()
        {
            var folders = _context.AllowedFolders.Where(folder => folder.To == folder.From);
            return View(folders);
        }
        public IActionResult Income()
        {
            var requests = _context.AddRequests.First(req => req.To.Equals(User.Identity.Name));
            return View("Index",requests);
        }
        public IActionResult Sended()
        {
            var currUser = _context.Users.First(p => p.UserName == User.Identity.Name);
            var requests = _context.AddRequests.Where(p=>p.FromId == currUser.Id).Include(p=>p.From);
            return View(requests);
        }
        /*
        public IActionResult Accept(int id)
        {
            ApplicationUser user = (ApplicationUser)_ctx.Users.First(user => user.UserName == User.Identity.Name);
            _context.SharedFolders.Include("Users").First(folder => folder.Id == id).Users.Add(user);
            _context.AddRequests.Remove(_context.AddRequests.First(folder=>folder.Id==id));
            _context.AllowedFolders.Add(new Models.AllowedFolder
            {
                To = User.Identity.Name,
                From = _context.SharedFolders.First(folder => folder.Id == id).UserName,
                Name = id.ToString()
            });
            _context.SaveChanges();
            return Redirect("Index");
        }*/
        public IActionResult Deny(int id)
        {
            _context.AddRequests.Remove(_context.AddRequests.First(folder => folder.Id == id));
            _context.SaveChanges();
            return Redirect("Index");
        }
        public IActionResult Send(string foldername,int id)
        {
           // ApplicationUser user = (ApplicationUser)_ctx.Users.First(user => user.UserName == User.Identity.Name);
            var requests = _context.AddRequests.Where(p => p.FolderId == id).Include(p=>p.To);
            ViewBag.currentFile = foldername;
            ViewBag.currentId = id;
            return View(requests);
        }
        [HttpPost]
        public IActionResult Add(string userName,int id)
        {
            var toUser = _context.Users.First(p => p.UserName == userName);
            var fromUser = _context.Users.First(p => p.UserName == User.Identity.Name);
            var folderId = ViewBag.currentId;
            var folder = _context.Files.First(p => p.Id == id);
            _context.AddRequests.Add(new AddRequest
            {

                ToId = toUser.Id,
                FromId =fromUser.Id ,
                Date = DateTime.Now,
                FolderId=folder.Id
        });
            _context.SaveChanges();
            return RedirectToAction("Send",new { filename =folder.Name,
                id = id
            });
        }

    }
}
