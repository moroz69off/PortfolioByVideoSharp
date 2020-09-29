using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRZVideoTr
{
    class Program
    {
        private static string appPath;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");

            appPath = Environment.CurrentDirectory;
            // потребуется ffmpeg.exe
            //        Links
            // https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-full.zip
            // https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip
            // https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-full-shared.zip

            if (!Directory.Exists(appPath + "/ffmpeg.exe"))
            {
                // dounload ffmpeg.exe
                Console.WriteLine(
                    "Need ffmpeg.exe\nHe is not there...\n"+
                    "Download here:\n"+
                    "https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-full.zip");
            }



            Console.ReadLine();
        }
    }
}
