using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Hubs
{
    public class Message
    {
        public string To;
        public string From;
        public string Date=DateTime.Now.ToString();
        public string FolderName;
    }
}
