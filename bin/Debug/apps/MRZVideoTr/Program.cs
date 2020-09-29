using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRZVideoTr
{
    class Program
    {
        static string appPath;
        static string pathToVideo;
        static string ffArgs;
        private static string videoName;

        static void Main(string[] args)
        {
            Console.Title = "MRZVideoTr";
            Console.WriteLine("Hello, World");

            appPath = Environment.CurrentDirectory;

            pathToVideo = "D:/Cubebrush - Dragon Knight - Fantasy character full course (2017)/01/01-01-GET-STARTED.mp4";

            char[] c = new char[] { '/', '\\' };
            int videoNameStartIndex = pathToVideo.LastIndexOfAny(c) + 1;
            videoName = pathToVideo.Substring(videoNameStartIndex);
            ffArgs = " -i \"" + pathToVideo + "\" -c:a copy " + videoName + ".aac";

            // потребуется ffmpeg.exe
            //        Links
            // https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-full.zip
            // https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip
            // https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-full-shared.zip

            bool isFF = File.Exists(appPath + "\\ffmpeg.exe");

            if (!isFF)
            {
                Console.WriteLine(
                    "Need ffmpeg.exe\nHe is not there...\n"+
                    "Download here:\n"+
                    "https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-full.zip");
                Console.WriteLine("For exit press \"Enter\" key");
                Console.ReadLine();
                return;
            }

            Process i = Process.Start("ffmpeg.exe", ffArgs);
            int processID = i.Id;
            Console.WriteLine(i.ProcessName);
            processID++;

            Console.WriteLine("Press \"Enter\" key, user!");
            Console.ReadLine();
        }
    }
}
