using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace WebApplication8.Models
{
    public class AddRequest
    {
        public int Id { get; set; }
        public IdentityUser From { get; set; }
        public IdentityUser To { get; set; }
        public SharedFolder Folder { get; set; }
        public DateTime Date { get; set; }

    }
}
