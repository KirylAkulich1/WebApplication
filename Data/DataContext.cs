using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication8.Models;

namespace WebApplication8.Data{
    /*
    public class FolderUserConfiguration:IEntityTypeConfiguration<FolderUser>
    {
        public void Configure(EntityTypeBuilder<FolderUser> builder)
        {
            builder.HasKey(p =>
            new { p.GuestId, p.FolderId });

            builder.HasOne(pt => pt.Guest)
                .WithMany(p => p.gustFolders)
                .HasForeignKey(pt => pt.GuestId);

            builder.HasOne(pt => pt.Folder)
                .WithMany(p => p.folderUsers)
                .HasForeignKey(pt => pt.FolderId);
        }

        
    }
    public class DataContext:DbContext{

        public DataContext(DbContextOptions<DataContext> options):base(options){

        }
        public DbSet<FileModel> Files{get;set;}
        public DbSet<Report> Reports { get; set; }
        public DbSet<SharedFolder> SharedFolders { get; set; }
        public DbSet<AddRequest> AddRequests { get; set; }
        public DbSet<AllowedFolder> AllowedFolders { get; set; }
        public DbSet<FolderUser> ShareFoldersUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FolderUser>().HasKey(p =>
            new { p.GuestId, p.FolderId });

            modelBuilder.Entity<FolderUser>().HasOne(pt => pt.Guest)
                .WithMany(p => p.gustFolders)
                .HasForeignKey(pt => pt.GuestId);

            modelBuilder.Entity<FolderUser>().HasOne(pt => pt.Folder)
                .WithMany(p => p.folderUsers)
                .HasForeignKey(pt => pt.FolderId);
            // modelBuilder.ApplyConfiguration(new FolderUserConfiguration());
            // modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            /* modelBuilder.Entity<AddRequest>()
                 .HasOne(p => p.From)
                 .WithMany(p=>p.outcomeRequests)
                 .HasForeignKey
                 (p => p.FromId)
                 .OnDelete(DeleteBehavior.Cascade);
             modelBuilder.Entity<AddRequest>()
                 .HasOne(p => p.To)
                 .WithMany(p=>p.incomeRequests)
                 .HasForeignKey
                 (p => p.ToId)
                 .OnDelete(DeleteBehavior.Cascade); ;

             modelBuilder.Entity<AddRequest>()
                 .HasOne(p => p.Folder)
                 .WithOne()
                 .HasForeignKey<AddRequest>
                 (p => p.FolderId);
            
        }


    }
    */
}