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
using NAudio.Wave;

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
        static SpeechSynthesizer SS;
        static SpeechRecognitionEngine SR;
        static List<string> RTextLines;

        static void Main(string[] args)
        {
            Console.Title = "MRZVideoTr";

            SS = new SpeechSynthesizer();
            SR = new SpeechRecognitionEngine(new CultureInfo("en-EN"));

            RTextLines = new List<string>();

            appPath = Environment.CurrentDirectory;

            // StreamReader sr = new StreamReader(appPath + "/01-01-GET-STARTED.mp4.aac");

            pathToVideo = @"C:\Users\moroz69off\OneDrive\MRZVS\Portfolio\bin\Debug\apps\MRZVideoTr\bin\Debug\01-Files-overview-2.mp4";
            videoName = GetVideoName(pathToVideo);

            MediaFoundationReader MFReader = new MediaFoundationReader(pathToVideo);

            ResamplerDmoStream RDStream = new ResamplerDmoStream(
                MFReader, 
                new WaveFormat(MFReader.WaveFormat.SampleRate, MFReader.WaveFormat.Channels));

            using(WaveFileWriter WFWriter = new WaveFileWriter(videoName + ".wav", MFReader.WaveFormat))
            {
                MFReader.CopyTo(WFWriter);
            }
            

            
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


            GetTextFromSpeechFile(videoName + ".aac");

            Console.WriteLine("Press \"Enter\" key, user!");

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

            SR.RecognizeCompleted += (s, e) => { SpeechFromRText(); };

            AudioState AudioState =SR.AudioState;
            if (AudioState== AudioState.Stopped)
            {
                SR.SetInputToWaveFile(videoName + ".wav");
                SR.SpeechRecognized += SR_SpeechRecognized;
                string topic = "grammar:dictation";
                DictationGrammar dg = new DictationGrammar(topic);
                SR.LoadGrammar(dg);
                SR.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private static void SpeechFromRText()
        {
            foreach (string line in RTextLines) { resultText += ". " + line; }
            SS.SetOutputToDefaultAudioDevice();
            SS.Speak(resultText);
        }

        private static void SR_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string txt = e.Result.Text;
            float confidence = e.Result.Confidence;
            Console.WriteLine("\nRecognized: " + txt);
            RTextLines.Add(txt);
            if (confidence < 0.60) return;
        }
    }
}
