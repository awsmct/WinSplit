using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				if (args[0] == "--help")
				{
					string help = "\nWinSplit it's command-line util for the fast split large file on lines.\n" +
								  "\nFor automatically counting lines use:\nwinsplit.exe <path_to_file> <count of splitted files> <output_name> <output_file_format_with_dot>\n\n" +
								  "Example:\nwinsplit.exe InputFile.json 12 OutputFile .json\n\n" +
								  "To use user-defined rows number:\nwinsplit.exe <path_to_file> <count_lines> <count_of_splitted_files> <output_name> <output_file_format_with_dot>\n\n" +
								  "Example:\nwinsplit.exe InputFile.json 5000 12 OutputFile .json";
					Console.WriteLine(help);
				}
				else if (args.Length == 4)
				{
					Splitting(0, args[0], Int32.Parse(args[1]), args[2], args[3], true);
					Console.WriteLine("Press any key to exit.");
					Console.ReadKey();
				}
				else if (args.Length == 5)
				{
					Splitting(Int32.Parse(args[1]), args[0], Int32.Parse(args[2]), args[3], args[4], false);
					Console.WriteLine("Press any key to exit.");
					Console.ReadKey();
				}
				else throw new Exception("Enter all arguments");

			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: {0}", ex.ToString());
				Console.WriteLine("Press any key to exit.");
				Console.ReadKey();
			}
		}

		private static void Splitting(int lineCount, string fileName, int fileCount, string outputFileName, string fileAttrib, bool autoCount)
		{
			if (autoCount)
			{
				Console.WriteLine("Counting lines in file...");
				lineCount = File.ReadLines(fileName).Count();
				Console.WriteLine("Ready, lines in file: {0}", lineCount);
			}

			StreamReader sr = new StreamReader(fileName);

			Console.WriteLine("Starting splitting file...");
			for (int i = 0; i < fileCount; i++)
			{
				int a = 0;
				string buff = string.Empty;
				fileName = outputFileName + i + fileAttrib;
				Console.WriteLine("Work with {0}", fileName);
				FileStream fs = new FileStream(fileName, FileMode.Create);
				while (a <= lineCount / fileCount && (buff = sr.ReadLine()) != null)
				{
					fs.Write(Encoding.UTF8.GetBytes(buff + "\n"));
					a++;
				}
				Console.WriteLine("File {0} ready, lines in file: {1}", fileName, a);
				a = 0;
			}
		}
	}
}
