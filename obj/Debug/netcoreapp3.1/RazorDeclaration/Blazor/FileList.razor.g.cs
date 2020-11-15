#pragma checksum "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18c4fd1b67a3271de7bc11ce024350fb46be8acb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication8.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using WebApplication8.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using WebApplication8.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class FileList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 167 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
      

    [Inject]
    DataContext dataContext { get; set; }
    [Inject]
    IWebHostEnvironment _appEnviroment { get; set; }
    [Inject]
    private IHttpContextAccessor httpContextAccessor { get; set; } = default!;
    [Inject]
    private ApplicationDbContext dbContext { get; set; }
    [Inject]
    UserManager<ApplicationUser> userManager { get; set; }
    [Inject]
    SignInManager<ApplicationUser> signInManager { get; set; }

    string currentUserName { get; set; }
    string currentPath { get; set; } = "/";
    string currentfolder { get; set; } = "";
    public IFileListEntry[] uploadedFile { get; set; }
    public string FolderName{ get; set; }
    async Task  HandleFileSelected(IFileListEntry[] files)
    {
        uploadedFile = files;
        if (uploadedFile != null)
        {
            Console.WriteLine("File Add");
            string UserName = httpContextAccessor.HttpContext.User.Identity.Name;
            string path = "/Files/" + UserName;

            if (!Directory.Exists(_appEnviroment.WebRootPath + path))
                Directory.CreateDirectory(_appEnviroment.WebRootPath + path);

            using (var fileStream = new FileStream(_appEnviroment.WebRootPath + path + "/" + uploadedFile[0].Name, FileMode.Create))
            {
                Console.WriteLine("File was Added0");
                await uploadedFile.FirstOrDefault().Data.CopyToAsync(fileStream);
                Console.WriteLine("File was Added1");
                dataContext.Files.Add(new FileModel
                {
                    Name = uploadedFile[0].Name,
                    Type = FileType.File,
                    Path = currentPath,
                    //UserName= httpContextAccessor.HttpContext.User.Identity.Name
                }) ;
                dataContext.SaveChanges();
            }

        }
    }

    public async Task onFileIploaded(MouseEventArgs e)
    {
        Console.WriteLine(uploadedFile);
        if (uploadedFile != null)
        {
            Console.WriteLine("File Add");
            string UserName = httpContextAccessor.HttpContext.User.Identity.Name;
            string path = "/Files/" + UserName;

            if (!Directory.Exists(_appEnviroment.WebRootPath + path))
                Directory.CreateDirectory(_appEnviroment.WebRootPath + path);

            using (var fileStream = new FileStream(_appEnviroment.WebRootPath + path+"/"+uploadedFile[0].Name, FileMode.Create))
            {
                Console.WriteLine("File was Added0");
                await uploadedFile.FirstOrDefault().Data.CopyToAsync(fileStream);
                Console.WriteLine("File was Added1");
                // dataContext.Files.Add(new FileModel
                //{
                //   Name = uploadedFile[0].Name,
                //  Type = FileType.File,
                // Path = currentPath,
                //User = await dbContext.Users.FirstOrDefaultAsync(u=> u.UserName==httpContextAccessor.HttpContext.User.Identity.Name)
                //}) ;
                Console.WriteLine("File was Added");
                dataContext.SaveChanges();
                Console.WriteLine("File was Added");
            }

        }

    }
    public IEnumerable<FileModel> GetFiles()
    {
        return dataContext.Files.Where(file =>currentPath==file.Path );
    }
    public string GetCurrentUserName()
    {
        return httpContextAccessor.HttpContext.User.Identity.Name;
    }
    public void addFolder()
    {
        if (FolderName!=null)
        {
            string UserName = httpContextAccessor.HttpContext.User.Identity.Name;
            string path = "/Files/" + UserName;
            if (Directory.Exists(path + "/" + FolderName))
                return;
            dataContext.Files.Add(new FileModel
            {
                Name = FolderName,
                Type = FileType.Folder,
                Path = currentPath,
                // UserName = httpContextAccessor.HttpContext.User.Identity.Name
            });
            dataContext.SaveChanges();
        }
    }
    public void FolderClicked(string filename)
    {
        currentfolder = filename;
        currentPath += "/" + filename;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
