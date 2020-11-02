using System;
using Algorithms;
using CMDLine;
using TI;
using TI.Declarator;
using TI.Declarator.ParserCommon;

namespace QuickParse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }

    interface IQDoc
    {
        string Path { get; set; }
        bool IsHappily { get; }
        string Result { get; }
    }
}
