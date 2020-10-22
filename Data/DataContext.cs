using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;

namespace WebApplication8.Data{
    public class DataContext:DbContext{

        public DataContext(DbContextOptions<DataContext> options):base(options){

        }
        public DbSet<FileModel> Files{get;set;}
        public DbSet<Report> Reports { get; set; }
        public DbSet<SharedFolder> SharedFolders { get; set; }
        public DbSet<AddRequest> AddRequests { get; set; }
        public DbSet<AllowedFolder> AllowedFolders { get; set; }
    }
}