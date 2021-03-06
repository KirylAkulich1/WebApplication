#pragma checksum "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18c4fd1b67a3271de7bc11ce024350fb46be8acb"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "id", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"sidebar-header\">\r\n        <h3>File Archive</h3>\r\n    </div>\r\n    ");
            __builder.AddMarkupContent(4, "<form id=\"uploadform\" asp-action=\"AddFile\" asp-controller=\"Home\" method=\"post\" enctype=\"multipart/form-data\">\r\n        <input id=\"buttonupload\" type=\"file\" name=\"uploadedFile\" size=\"chars\" multiple onchange=\"submitForm(\'uploadform\');\">\r\n    </form>\r\n    ");
            __builder.AddMarkupContent(5, "<button id=\"upload-btn\" onclick=\"thisFileUpload;\">Choose File</button>\r\n    ");
            __builder.OpenElement(6, "ul");
            __builder.AddAttribute(7, "class", "list-unstyled components");
            __builder.AddMarkupContent(8, "\r\n       \r\n\r\n        ");
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "class", "active");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, "<a href=\"#homeSubmenu\" data-toggle=\"collapse\" aria-expanded=\"false\" class=\"dropdown-toggle\">Home</a>\r\n            ");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "collapse list-unstyled");
            __builder.AddAttribute(15, "id", "homeSubmenu");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "li");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", "#");
            __builder.AddContent(21, 
#nullable restore
#line 16 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                                 GetCurrentUserName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<li>\r\n                    <a href=\"#\">Home 2</a>\r\n                </li>\r\n                ");
            __builder.AddMarkupContent(25, "<li>\r\n                    <a href=\"#\">Home 3</a>\r\n                </li>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.AddMarkupContent(28, "<li>\r\n            <a href=\"#\">About</a>\r\n        </li>\r\n        ");
            __builder.OpenElement(29, "li");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.AddMarkupContent(31, "<a href=\"#pageSubmenu\" data-toggle=\"collapse\" aria-expanded=\"false\" class=\"dropdown-toggle\">Pages</a>\r\n            ");
            __builder.OpenElement(32, "ul");
            __builder.AddAttribute(33, "class", "collapse list-unstyled");
            __builder.AddAttribute(34, "id", "pageSubmenu");
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "li");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "#");
            __builder.AddContent(40, 
#nullable restore
#line 33 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                                 GetCurrentUserName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.AddMarkupContent(43, "<li>\r\n                    <a href=\"#\">Page 2</a>\r\n                </li>\r\n                ");
            __builder.AddMarkupContent(44, "<li>\r\n                    <a href=\"#\">Page 3</a>\r\n                </li>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.AddMarkupContent(47, "<li>\r\n            <a href=\"#\">Portfolio</a>\r\n        </li>\r\n        ");
            __builder.AddMarkupContent(48, "<li>\r\n            <a href=\"#\">Contact</a>\r\n        </li>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n    ");
            __builder.OpenElement(50, "ul");
            __builder.AddAttribute(51, "class", "list-unstyled CTAs");
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "li");
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.AddMarkupContent(55, "<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModalCenter\">\r\n                Create Folder\r\n            </button>\r\n\r\n            \r\n            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "modal fade");
            __builder.AddAttribute(58, "id", "exampleModalCenter");
            __builder.AddAttribute(59, "tabindex", "-1");
            __builder.AddAttribute(60, "role", "dialog");
            __builder.AddAttribute(61, "aria-labelledby", "exampleModalCenterTitle");
            __builder.AddAttribute(62, "aria-hidden", "true");
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(66, "role", "document");
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "modal-content");
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.AddMarkupContent(71, @"<div class=""modal-header"">
                            <h5 class=""modal-title"" id=""exampleModalLongTitle"">Modal title</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "modal-body");
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                                                FolderName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FolderName = __value, FolderName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "modal-footer");
            __builder.AddMarkupContent(82, "\r\n                            ");
            __builder.AddMarkupContent(83, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n                            ");
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "type", "button");
            __builder.AddAttribute(86, "class", "btn btn-primary");
            __builder.AddAttribute(87, "data-dismiss", "modal");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                                                                                                         addFolder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(89, "onclick", true);
            __builder.AddContent(90, "Save folder");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.AddMarkupContent(97, "<li>\r\n            <a href=\"https://bootstrapious.com/p/bootstrap-sidebar\" class=\"article\">Back to article</a>\r\n        </li>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\n\r\n");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "id", "content");
            __builder.AddMarkupContent(102, "\r\n\r\n    ");
            __builder.AddMarkupContent(103, @"<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <div class=""container-fluid"">

            <button type=""button"" id=""sidebarCollapse"" class=""btn btn-info"">
                <span>Toggle Sidebar</span>
            </button>
            <button class=""btn btn-dark d-inline-block d-lg-none ml-auto"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <i class=""fas fa-align-justify""></i>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""nav navbar-nav ml-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">Page</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Page</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Page</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Page</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>


    ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "row");
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "col-12");
            __builder.AddMarkupContent(109, "\r\n            ");
            __builder.AddMarkupContent(110, "<h6 class=\"text-muted\">List Group</h6>\r\n            ");
            __builder.OpenElement(111, "ul");
            __builder.AddAttribute(112, "class", "list-group");
            __builder.AddMarkupContent(113, "\r\n                \r\n");
#nullable restore
#line 122 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
           foreach (var file in GetFiles())
          {

#line default
#line hidden
#nullable disable
            __builder.AddContent(114, "                ");
            __builder.OpenElement(115, "li");
            __builder.AddAttribute(116, "class", "list-group-item");
            __builder.AddMarkupContent(117, "\r\n\r\n                    <span class=\"glyphicon glyphicon-pencil\"></span>\r\n");
#nullable restore
#line 127 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                     if (file.Type == FileType.Folder)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(118, "                        <i class=\"fa fa-folder\"></i>\r\n                        ");
            __builder.OpenElement(119, "a");
            __builder.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 130 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                                       e =>FolderClicked(file.Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(121, 
#nullable restore
#line 130 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                                                                       file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 131 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(123, "                        <i class=\"fa fa-file\"></i>\r\n                        ");
            __builder.OpenElement(124, "a");
            __builder.AddContent(125, 
#nullable restore
#line 135 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                            file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
#nullable restore
#line 136 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(127, "\r\n                    \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 144 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
          }

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n            ");
            __builder.OpenElement(131, "form");
            __builder.AddMarkupContent(132, "\r\n\r\n                ");
            __builder.AddMarkupContent(133, "<label>Upload Your File </label>\r\n                \r\n\r\n\r\n                ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(134);
            __builder.AddAttribute(135, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 157 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                                     HandleFileSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(136, "\r\n\r\n\r\n                ");
            __builder.OpenElement(137, "button");
            __builder.AddAttribute(138, "type", "submit");
            __builder.AddAttribute(139, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 160 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Blazor\FileList.razor"
                                                onFileIploaded

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(140, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n       \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n   \r\n");
            __builder.CloseElement();
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
