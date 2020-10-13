using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication8.Models{

    public enum FileType{
        Folder,
        Image,
        File
    }
    public class FileModel{
        public int Id{get;set;}
        public string Name{get;set;}
        public string Path{get;set;}
        public FileType Type{get;set;}
        public string UserName { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}