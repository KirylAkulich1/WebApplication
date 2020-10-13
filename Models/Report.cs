using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;

namespace WebApplication8.Models
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime ReportDate;
        public string UserName { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public FileModel File { get; set; }
        public string Theme { get; set; }
        public string Body { get; set; }

    }
}
