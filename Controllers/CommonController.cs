using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication8.Data;
using WebApplication8.Models;
using Microsoft.EntityFrameworkCore;
using MailKit.Net.Smtp;
using MimeKit;
using WebApplication8.Models.Mails;
using MailKit.Security;
using System.Security.Authentication;

namespace WebApplication8.Controllers
{
    public class CommonController : Controller
    {

        private readonly ILogger<HomeController> _logger;
       
        private readonly IHttpContextAccessor _ctx;
        private readonly IWebHostEnvironment _appEnviroment;
        private readonly ApplicationDbContext _context;
        private readonly MailMetaData _notificationMetadata;
        public CommonController(ILogger<HomeController> logger, 
            IHttpContextAccessor httpContextAccessor, IWebHostEnvironment appEnviroment, ApplicationDbContext userctx,MailMetaData _notification)
        {
            _logger = logger;

            _ctx = httpContextAccessor;
            _appEnviroment = appEnviroment;
            _context = userctx;
            _notificationMetadata = _notification;
        }
        /*
        public IActionResult Index(string user)
        {
            if (user == null)
                user = User.Identity.Name;
            ApplicationUser currUser = (ApplicationUser)_userctx.Users.First(user => user.UserName == User.Identity.Name);
            if (user == User.Identity.Name)
                return View(_context.SharedFolders.Include("Folder").Where(folder => folder.UserName == user));
            else
            {
       
                return View(_context.SharedFolders.
                    Where(folder => folder.UserName == user).
                    Include("Users").
                    Where(folder => folder.Users.Contains(currUser)));

            }
        }*/
        public IActionResult AddShared(string foldername)
        {
            if (!Directory.Exists(_appEnviroment.WebRootPath + "/Files/" + User.Identity.Name + "/Shared"))
                Directory.CreateDirectory(_appEnviroment.WebRootPath + "/Files/" + User.Identity.Name + "/Shared");
            string filepath = _appEnviroment.WebRootPath + "/Files/" + User.Identity.Name + "/Shared/"+foldername;
            FileModel fileModel = new FileModel { UserName = User.Identity.Name, Name = foldername, Type = FileType.Folder, Path =filepath };
            _context.SharedFolders.Add(new SharedFolder
            {
                OwnerId = User.Identity.Name,
                Folder = fileModel,
                SharedPath = "/shared",

            });
            _context.SaveChanges();
           // Get();
            return RedirectToAction("Index");
        }
        public IActionResult AddUser(string username,string sharedid)
        {
            var fromUser = _context.Users.First(p => p.UserName == username);
            var toUser = _context.Users.First(p => p.UserName == User.Identity.Name);
            _context.AddRequests.Add(new AddRequest
            {
                ToId=toUser.Id,
                FromId=fromUser.Id,
                Date=DateTime.Now,
                FolderId=Int32.Parse(sharedid)
            });
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult About(int id)
        {
            SharedFolder folder = _context.SharedFolders.Include("Users").First(folder=>folder.Id==id);
            return View(folder);
        }
    }
    
}
