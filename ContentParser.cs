using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSharpAppliedPortfolio
{
    class ContentParser
    {
        public string appPath = Directory.GetCurrentDirectory()+"\\apps";
        public string[] folders;
        public string[] apps;
         public string[] GetFolders()
        {
             folders = Directory.GetDirectories(appPath);
             for (int i = 0; i < folders.Length; i++)
             {
                 folders[i] = folders[i].Remove(0, folders[i].IndexOf("apps") + 5);
             }
             return folders;
        }
    }
}
