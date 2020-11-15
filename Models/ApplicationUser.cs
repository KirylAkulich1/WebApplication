using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    public class ApplicationUser:IdentityUser
    {
        [InverseProperty("To")]
        public ICollection<AddRequest> incomeRequests { get; set; }
        [InverseProperty("From")]
        public ICollection<AddRequest> outcomeRequests { get; set; }
       // [InverseProperty("OwnerId")]
        //public ICollection<SharedFile> selfFoldrs { get; set; }
        public ICollection<FolderUser> gustFolders { get; set; }
    }
}
