using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using NAudio.Wave;

namespace MRZVideoTr
{
    class Program
    {
        static string appPath;
        static string pathToVideo;
        static string resultText;
        private static string videoName;
      //static bool done = false;
      //static bool speechOn = true;
        static List<string> RTextLines;

        static void Main(string[] args)
        {
            Console.Title = "MRZVideoTr";

            CultureInfo cultureInfo = new CultureInfo(25);
            var ci = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);
            var ciRu = ci[328];

            CultureInfo CIintl = new CultureInfo("en-EN", false);

            RTextLines = new List<string>();

            appPath = Environment.CurrentDirectory;

            pathToVideo = @"01-Files-overview-2.mp4";
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

            SR.RecognizeCompleted += (s, e) => { SpeechFromRText(); };

            AudioState AudioState =SR.AudioState;
            if (AudioState== AudioState.Stopped)
            {
                SR.SetInputToWaveFile(videoName + ".wav");
                SR.SpeechRecognized += SR_SpeechRecognized;

                // Create a default dictation grammar.  
                DictationGrammar DefaultDictationGrammar = new DictationGrammar();
                DefaultDictationGrammar.Name = "DefaultDictation";
                DefaultDictationGrammar.Enabled = true;

                // Create the spelling dictation grammar.  
                DictationGrammar SpellingDictationGrammar = new DictationGrammar("grammar:dictation#spelling");
                SpellingDictationGrammar.Name = "SpellingDictation";
                SpellingDictationGrammar.Enabled = true;

                // Create the question dictation grammar.  
                DictationGrammar M3DDictationGrammar = new DictationGrammar("grammar:dictation#m3dict");
                M3DDictationGrammar.Name = "M3Ddictation";
                M3DDictationGrammar.Enabled = true;

                // Create a SpeechRecognitionEngine object and add the grammars to it.  
                SR.LoadGrammar(DefaultDictationGrammar);
                SR.LoadGrammar(SpellingDictationGrammar);
             // SR.LoadGrammar(M3DDictationGrammar);

                // Add a context to M3DDictationGrammar.  
             // M3DDictationGrammar.SetDictationContext("polygon", "model");// ?????????

                SR.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private static void SpeechFromRText()
        {
            foreach (string line in RTextLines) { resultText += ". " + line; }
        }
    }
}
