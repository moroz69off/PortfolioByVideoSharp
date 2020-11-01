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
        static int samplingFrequency = 44100000; // Temporarily, there will be GetSampling (audio);

        static string appPath;
        static string pathToVideo;
        static string resultText;
        private static string videoName;
        static bool done = false;
        static bool speechOn = true;
        static List<string> RTextLines;
        private static ResamplerDmoStream RDStream;
        static WaveFormat WFormat;
        static MediaFoundationReader MFReader;

        static void Main(string[] args)
        {
            Console.Title = "MRZVideoTr";

            CultureInfo[] ci      = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);
            CultureInfo ciRu      = ci[311];
            CultureInfo ciEn      = CultureInfo.GetCultureInfo("en-EN");
            CultureInfo ciCurrent = CultureInfo.CurrentCulture;

            RTextLines = new List<string>();

            appPath = Environment.CurrentDirectory;

            pathToVideo = @"overview-2.mp4";
            videoName = GetVideoName(pathToVideo);

            MFReader = new MediaFoundationReader(pathToVideo);
            WFormat = new WaveFormat(MFReader.WaveFormat.SampleRate, MFReader.WaveFormat.Channels);
            RDStream = new ResamplerDmoStream( MFReader, WFormat);

            string audioName = videoName + ".wav";

            using (WaveFileWriter WFWriter = new WaveFileWriter(audioName, MFReader.WaveFormat)) 
            { MFReader.CopyTo(WFWriter); }

            samplingFrequency = GetSampling(audioName);

            GetTextFromSpeechFile(audioName);

            Console.ReadLine();
        }

        /// <summary>
        /// Получает величину дискретизации аудио потока
        /// </summary>
        /// <param name="audio">Строка</param>
        /// <returns>int SampleRate</returns>
        private static int GetSampling(string audio) => 
            RDStream.WaveFormat.SampleRate;

        /// <summary>
        /// получает имя файла с расширением
        /// </summary>
        /// <param name="pathToVideo"></param>
        /// <returns>string video file name (with ext)</returns>
        private static string GetVideoName(string pathToVideo) => 
            pathToVideo.Substring(pathToVideo.LastIndexOfAny(new char[] { '/', '\\' }) + 1);

        private static void GetTextFromSpeechFile(string speeStr)
        {
            Console.WriteLine(speeStr + " to text...");
            // Recognition service -

            Console.WriteLine();
        }

        private static void SpeechFromRText()
        {
            foreach (string line in RTextLines) { resultText += ". " + line; }
        }
    }
}
// "overview-2.mp4"
