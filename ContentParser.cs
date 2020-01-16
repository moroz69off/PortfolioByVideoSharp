using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VideoSharpAppliedPortfolio
{
    class ContentParser
    {
        public string appPath = Directory.GetCurrentDirectory()+"\\apps";
        public string[] folders;
        public string[] apps;
        public bool isDir;
        public string[] GetFolders()
        {
            isDir = Directory.Exists(appPath);
            if (!isDir)Directory.CreateDirectory(appPath);
             folders = Directory.GetDirectories(appPath);
             for (int i = 0; i < folders.Length; i++)
             {
                 folders[i] = folders[i].Remove(0, folders[i].IndexOf("apps") + 5);
             }
             return folders;
        }

        public string GetAssemlyName(int tagN)
        {
            apps = GetFolders();
            string assemblyName="";
            string projPath = "apps/" + apps[tagN]+ "/" + apps[tagN];
            string[] files = Directory.GetFiles(projPath, "*.csproj");//csproj file path
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(files[0]);
            XmlElement root = xmlDoc.DocumentElement;
            foreach (XmlNode node in root)
            {
                if (node.Attributes.Count > 0)
                {
                    XmlNode attr = node.Attributes.GetNamedItem("PropertyGroup");
                    if (attr != null)
                    {
                        var Name = attr.Value;
                    }
                }
                foreach (XmlNode item in node.ChildNodes)
                {
                    if (item.Name == "AssemblyName")
                    {
                        assemblyName = item.InnerText;
                        return assemblyName;
                    }
                }
            }
            return assemblyName;
        }
    }
}
