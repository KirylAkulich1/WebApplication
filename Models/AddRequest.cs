using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace WebApplication8.Models
{
    public class AddRequest
    {
        public int Id { get; set; }
       
        public string FromId { get; set; }
        public ApplicationUser From { get; set; }
   
        public string? ToId { get; set; }
        public ApplicationUser To { get; set; }
        public Boolean Accepted { get; set; }
        public int FolderId { get; set; }
        public FileModel Folder { get; set; }
        public DateTime Date { get; set; }

    }
}
