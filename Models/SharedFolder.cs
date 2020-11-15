using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace WebApplication8.Models
{
    public class SharedFolder
    {
        public int Id { get; set; }
        public FileModel Folder { get; set; }
        public string SharedPath { get; set; }
        public ICollection<FolderUser> folderUsers { get; set; }
        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }
       
    }
}
