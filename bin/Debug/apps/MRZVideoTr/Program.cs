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

        static void Main(string[] args)
        {
            Console.Title = "MRZVideoTr";
            Console.WriteLine("Hello, World");

            SS = new SpeechSynthesizer();

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

            GetTextFromSpeechFile(videoName + ".aac");

            Console.WriteLine("Press \"Enter\" key, user!");
            
            Console.ReadLine();
        }

        private static void GetTextFromSpeechFile(string speeStr)
        {
            Console.WriteLine(speeStr + " to text...");
          //SS.SetOutputToWaveFile("Скороговорка.wav", new SpeechAudioFormatInfo(44000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
            SS.SpeakAsync("В четверг четвертого числа в четыре с четвертью часа.лигурийский регулировщик регулировал в Лигурии,но тридцать три корабля лавировали, лавировали, да так и не вылавировали, а потом протокол про протокол протоколом запротоколировал, как интервьюером интервьюируемый лигурийский регулировщик речисто, да не чисто рапортовал, да не дорапортовал дорапортовывал да так зарапортовался про размокропогодившуюся погоду что, дабы инцидент не стал претендентом на судебный прецедент,лигурийский регулировщик акклиматизировался в неконституционном Константинополе,где хохлатые хохотушки хохотом хохотали и кричали турке, который начерно обкурен трубкой: не кури, турка, трубку, купи лучше кипу пик, лучше пик кипу купи, а то придет бомбардир из Бранденбурга — бомбами забомбардирует за то, что некто чернорылый у него полдвора рылом изрыл, вырыл и подрыл, но на самом деле турка не был в деле, да и Клара-к крале в то время кралась к ларю, пока Карл у Клары кораллы крал, за что Клара у Карла украла кларнет, а потом на дворе деготниковой вдовы Варвары два этих вора дрова воровали. Но грех — не смех — не уложить в орех: о Кларе с Карлом во мраке все раки шумели в драке, - вот и не до бомбардира ворам было, и не до деготниковой вдовы, и не до деготниковых детей, зато рассердившаяся вдова убрала в сарай дрова: раз дрова, два дрова, три дрова — не вместились все дрова, и два дровосека, два- дровокола- дроворуба для расчувствовавшейся Варвары выдворили дрова вширь двора обратно на дровяной двор, где цапля чахла, цапля сохла, цапля сдохла, цыпленок же цапли цепко цеплялся за цепь, молодец против овец, а против молодца сам овца, которой носит Сеня сено в сани, потом везет Сеньку Соньку с Санькой на санках: санки- скок, Сеньку- в бок, Соньку- в лоб, все- в сугроб, а Сашка только шапкой шишки сшиб, затем по шоссе Саша пошел, Саша на шоссе саше нашел. Сонька же — Сашкина подружка шла по шоссе и сосала сушку, да притом у Соньки-вертушки во рту еще и три ватрушки — аккурат в медовик, но ей не до медовика — Сонька и с ватрушками во рту пономаря перепономарит, - перевыпономарит: жужжит, как жужелица, ужжит, да кружится: была у Фрола — Фролу на Лавра наврала, пойдет к Лавру на Фрола Лавру наврет, что — вахмистр с вахмистршей, ротмистр с ротмистршей, что у ужа — ужата, а у ежа- ежата, а у него высокопоставленный гость унес трость, и вскоре опять пять ребят съели пять опят с полчетвертью четверика чечевицы без червоточины, и тысячу шестьсот шестьдесят шесть пирогов с творогом из сыворотки из-под простокваши, - о всем о том около кола колокола звоном раззванивали, да так, что даже Константин — зальцбуржский бссперспективняк из-под бронетранспортера констатировал: как все колокола не переколоколовать, не перевыколоколовать, так и всех скороговорок не перескороговорить, не перевыскороговорить. Но попытка — не пытка.");
        }
    }
}
