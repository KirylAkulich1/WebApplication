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
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _ctx;
        private readonly IWebHostEnvironment _appEnviroment;
        private readonly ApplicationDbContext _userctx;
        private readonly MailMetaData _notificationMetadata;
        public CommonController(ILogger<HomeController> logger, DataContext context,
            IHttpContextAccessor httpContextAccessor, IWebHostEnvironment appEnviroment, ApplicationDbContext userctx,MailMetaData _notification)
        {
            _logger = logger;
            _context = context;
            _ctx = httpContextAccessor;
            _appEnviroment = appEnviroment;
            _userctx = userctx;
            _notificationMetadata = _notification;
        }
        public IActionResult Index()
        {
            Get();
            return View(_context.SharedFolders.Where(folder=>folder.SharedPath=="/shared").Include("Folder"));
        }
        public IActionResult AddShared(string foldername)
        {
            if (!Directory.Exists(_appEnviroment.WebRootPath + "/Files/" + User.Identity.Name + "/Shared"))
                Directory.CreateDirectory(_appEnviroment.WebRootPath + "/Files/" + User.Identity.Name + "/Shared");
            string filepath = _appEnviroment.WebRootPath + "/Files/" + User.Identity.Name + "/Shared/"+foldername;
            FileModel fileModel = new FileModel { UserName = User.Identity.Name, Name = foldername, Type = FileType.Folder, Path =filepath };
            _context.SharedFolders.Add(new SharedFolder
            {
                UserName = User.Identity.Name,
                Folder = fileModel,
                SharedPath = "/shared",

            });
            _context.SaveChanges();
            Get();
            return RedirectToAction("Index");
        }
        private MimeMessage CreateMimeMessageFromEmailMessage(EmailMessage message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(message.Sender);
            mimeMessage.To.Add(message.Reciever);
            mimeMessage.Subject = message.Subject;
            mimeMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            { Text = message.Content };
            return mimeMessage;
        }
        public string Get()
        {
            EmailMessage message = new EmailMessage();
            message.Sender = new MailboxAddress("Self", _notificationMetadata.Sender);
            message.Reciever = new MailboxAddress("Self", _notificationMetadata.Reciever);
            message.Subject = "Welcome";
            message.Content = "Hello World!";
            var mimeMessage = CreateMimeMessageFromEmailMessage(message);
            using (SmtpClient smtpClient = new SmtpClient())
            {
//                smtpClient.SslProtocols = SslProtocols.Ssl3 | SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12 | SslProtocols.Tls13;

                smtpClient.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtpClient.Authenticate(_notificationMetadata.UserName,
                _notificationMetadata.Password);
                smtpClient.Send(mimeMessage);
                smtpClient.Disconnect(true);
            }
            return "Email sent successfully";
        }
    }
    
}
