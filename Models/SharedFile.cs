using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace WebApplication8.Models
{
    public class SharedFile
    {
        public int Id { get; set; }
        public FileModel FModel { get; set; }
        ICollection <IdentityUser> Users { get; set; }
    }
}
