using System;

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
