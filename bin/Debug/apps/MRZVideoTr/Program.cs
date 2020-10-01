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
        static SpeechRecognitionEngine SR;

        static void Main(string[] args)
        {
            Console.Title = "MRZVideoTr";

            SS = new SpeechSynthesizer();
            SR = new SpeechRecognitionEngine();

            appPath = Environment.CurrentDirectory;

            StreamReader sr = new StreamReader(appPath + "/01-01-GET-STARTED.mp4.aac");

         

            pathToVideo = "D:/Cubebrush - Dragon Knight - Fantasy character full course (2017)/01/01-01-GET-STARTED.mp4";

            char[] c = new char[2] { '/', '\\' };
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

            GetTextFromSpeechFile(videoName + ".aac");

            Console.WriteLine("Press \"Enter\" key, user!");
            
            Console.ReadLine();
        }

        private static void GetTextFromSpeechFile(string speeStr)
        {
            Console.WriteLine(speeStr + " to text...");
            TaskCompletionSource<int> stopRecognition = new TaskCompletionSource<int>();

            SR.RecognizeCompleted += (s, e) => { Console.WriteLine($"RECOGNIZING: Text={e.Result.Text}"); };

            AudioState AudioState =SR.AudioState;
            if (AudioState== AudioState.Stopped)
            {
                SR.SetInputToWaveFile(videoName + ".aac");
                SR.SpeechRecognized += SR_SpeechRecognized;

                SR.RecognizeAsync(RecognizeMode.Single);
            }
        }

        private static void SR_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string txt = e.Result.Text;
            float confidence = e.Result.Confidence;
            Console.WriteLine("\nRecognized: " + txt);
            if (confidence < 0.60) return;
        }
    }
}
