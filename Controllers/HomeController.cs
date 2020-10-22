using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using WebApplication8.Models;
using WebApplication8.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using System.IO;

namespace WebApplication8.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _ctx;
        private readonly IWebHostEnvironment _appEnviroment;
        private readonly ApplicationDbContext _userctx;
        public HomeController(ILogger<HomeController> logger,DataContext context,
            IHttpContextAccessor httpContextAccessor,IWebHostEnvironment appEnviroment,ApplicationDbContext userctx)
        {
            _logger = logger;
            _context = context;
            _ctx = httpContextAccessor;
            _appEnviroment = appEnviroment;
            _userctx = userctx;
        }

        public IActionResult Index(string path="/")
        {
            _logger.LogInformation(path);
            ViewBag.CurrentPath = path;
            TempData["path"] = path;
         
            return View(_context.Files.Where(file=>file.UserName==User.Identity.Name && file.Path==path));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       [HttpPost]
        public IActionResult CreateFolder(string folderpath,string foldername)
        {
            string fullpath = _appEnviroment.WebRootPath+"/Files/" + User.Identity.Name + folderpath;
            string returnpath = folderpath[..];
            if (!Directory.Exists(fullpath + foldername))
            {
                Directory.CreateDirectory(fullpath + foldername);
                _context.Files.Add(new FileModel
                {
                    Name = foldername,
                    Path = folderpath,
                    UserName = User.Identity.Name,
                    Type = FileType.Folder
                });
                
            }
            _context.SaveChanges();
            Console.WriteLine(folderpath.Replace("/", "-"));
            return RedirectToAction("Index",new { path=folderpath});
        }
        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile,string Path)
        {
            if (uploadedFile != null)
            {
                bool tmp = Directory.Exists(_appEnviroment.WebRootPath + "/Files/" + User.Identity.Name);
                if (!tmp)
                    Directory.CreateDirectory(_appEnviroment.WebRootPath + "/Files/" + User.Identity.Name);
                string filepath = _appEnviroment.WebRootPath + "/Files/" + User.Identity.Name+Path;
                using (var fileStrem=new FileStream(filepath + uploadedFile.Name, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStrem);
                    _context.Files.Add(new FileModel
                    {
                        Name = uploadedFile.FileName,
                        Type=FileType.File,
                        UserName=User.Identity.Name,
                        Path= Path

                    });
                    _context.SaveChanges();
                  

                }

            }
            return RedirectToAction("Index", new { path = Path});
        }
        public IActionResult PostReport(string FileId,string Path,string ReportTheme, string ReportBody)
        {
            FileModel model = _context.Files.First(file => file.Id == Int32.Parse(FileId));
            _context.Reports.Add(new Report
            {
                UserName=User.Identity.Name,
                Theme = ReportTheme,
                ReportDate = DateTime.Now,
                Body = ReportBody,
                File = model
            });
            _context.SaveChanges();
            return RedirectToAction("Index", new { path = Path });
        }
        public IActionResult MakeShared(int FileId,string Path)
        {
            FileModel file = _context.Files.First(file => file.Id == FileId);
           // SharedFolder sharedFolder = new SharedFolder { Folder = file, SharedPath = Path };
            return RedirectToAction("Index", new { path = Path });
        }
        [HttpGet]
        public ActionResult GetFiles()
        {
            string Path = "/";
            return PartialView("_FileListPartial", _context.Files.Where(file => file.UserName == User.Identity.Name && file.Path == Path));
        }
    }
}
