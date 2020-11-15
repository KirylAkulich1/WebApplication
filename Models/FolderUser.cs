using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    public class FolderUser
    {
        public string GuestId { get; set; }
        public ApplicationUser Guest { get; set; }
        public int FolderId { get; set; }
        public SharedFolder Folder { get; set; }
    }
}
