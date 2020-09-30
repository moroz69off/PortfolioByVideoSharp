using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Speech;
using System.Speech.AudioFormat;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace MRZVideoTr
{
    class Program
    {
        static string appPath;
        static string pathToVideo;
        static string ffArgs;
        private static string videoName;
        static bool done = false;
        static bool speechOn = true;
        static SpeechSynthesizer SS;
        static SpeechRecognitionEngine SRE;

        static void Main(string[] args)
        {
            Console.Title = "MRZVideoTr";
            Console.WriteLine("Hello, World");

            SS = new SpeechSynthesizer(); 
            SRE = new SpeechRecognitionEngine();

            appPath = Environment.CurrentDirectory;

            StreamReader SR = new StreamReader(appPath + "/01-01-GET-STARTED.mp4.aac");

            SRE.SetInputToAudioStream(SR.BaseStream, new SpeechAudioFormatInfo(44000, AudioBitsPerSample.Sixteen, AudioChannel.Stereo));

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

            //Process i = Process.Start("ffmpeg.exe", ffArgs);
            //int processID = i.Id;

            GetTextFromSpeechFile(videoName + ".aac");

            Console.WriteLine("Press \"Enter\" key, user!");
            
            Console.ReadLine();
        }

        private static void GetTextFromSpeechFile(string speeStr)
        {
            Console.WriteLine(speeStr + " to text...");
          //SS.SetOutputToWaveFile("Скороговорка.wav", new SpeechAudioFormatInfo(44000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
            SS.SpeakAsync("тридцать три корабля лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали, лавировали");
        }
    }
}
