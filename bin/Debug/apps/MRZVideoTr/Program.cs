using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using SYS_SP   = System.Speech;
using SYS_SPAF = System.Speech.AudioFormat;
using SYS_SPRC = System.Speech.Recognition;
using SYS_SPST = System.Speech.Synthesis;

using MS_SP   = Microsoft.Speech;
using MS_SPAF = Microsoft.Speech.AudioFormat;
using MS_SPRC = Microsoft.Speech.Recognition;
using MS_SPST = Microsoft.Speech.Text;

using NAudio.Wave;
using Microsoft.Speech.Recognition;

namespace MRZVideoTr
{
    class Program
    {
        static string appPath;
        static string pathToVideo;
        static string resultText;
        private static string videoName;
        static bool done = false;
        static bool speechOn = true;
        static List<string> RTextLines;

        static void Main(string[] args)
        {
            Console.Title = "MRZVideoTr";

            CultureInfo[] ci        = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);
            CultureInfo ciRu      = ci[311];
            CultureInfo ciEn      = CultureInfo.GetCultureInfo("en-EN");
            CultureInfo ciCurrent = CultureInfo.CurrentCulture;

            RTextLines = new List<string>();

            appPath = Environment.CurrentDirectory;

            pathToVideo = @"D:\Cubebrush - Dragon Knight - Fantasy character full course (2017)\01\01-02-SCULPTING-TOOLS.mp4";
            videoName = GetVideoName(pathToVideo);

            MediaFoundationReader MFReader = new MediaFoundationReader(pathToVideo);
            WaveFormat WFormat = new WaveFormat(MFReader.WaveFormat.SampleRate, MFReader.WaveFormat.Channels);
            ResamplerDmoStream RDStream = new ResamplerDmoStream( MFReader, WFormat);

            using(WaveFileWriter WFWriter = new WaveFileWriter(videoName + ".wav", MFReader.WaveFormat)) 
            { MFReader.CopyTo(WFWriter); }

            //ffArgs = " -i \"" + pathToVideo + "\" -c:a copy " + videoName + ".aac";
            //// потребуется ffmpeg.exe
            ////        Links
            //// https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-full.zip
            //// https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip
            //// https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-full-shared.zip
            //bool isFF = File.Exists(appPath + "\\ffmpeg.exe");
            //if (!isFF)
            //{
            //    Console.WriteLine(
            //        "Need ffmpeg.exe\nHe is not there...\n"+
            //        "Download here:\n"+
            //        "https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-full.zip");
            //    Console.WriteLine("For exit press \"Enter\" key");
            //    Console.ReadLine();
            //    return;
            //}
            //Process i = Process.Start("ffmpeg.exe", ffArgs);
            //int processID = i.Id;
            
            GetTextFromSpeechFile(videoName + ".wav");

            Console.ReadLine();
        }
        /// <summary>
        /// Обрезает весь путь к файлу и получает только имя файла с расширением
        /// </summary>
        /// <param name="pathToVideo"></param>
        /// <returns>string video (file) name (with ext)</returns>
        private static string GetVideoName(string pathToVideo)
        {
            char[] c = new char[2] { '/', '\\' };
            int videoNameStartIndex = pathToVideo.LastIndexOfAny(c) + 1;
            return pathToVideo.Substring(videoNameStartIndex);
        }

        private static void GetTextFromSpeechFile(string speeStr)
        {
            Console.WriteLine(speeStr + " to text...");

            Console.WriteLine();
        }

        private static void SpeechFromRText()
        {
            foreach (string line in RTextLines) { resultText += ". " + line; }
        }
    }
}
