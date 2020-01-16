using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSharpAppliedPortfolio
{
    /// <summary>
    /// This class must create new projects in the root solution when adding a folder with a Visual Studio project.
    /// </summary>
    class Projects
    {
        static ContentParser Parser = new ContentParser();
        string appPath = Parser.appPath;
        string[] folders = Parser.GetFolders();
    }
}
