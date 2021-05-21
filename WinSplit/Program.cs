using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				if (args.Length != 0)
				{
					int a = 0, lineCount = 0, fileCount = 0;
					string fileName, buff, outputFileName, fileAttrib = string.Empty;
					fileName = args[0];
					Int32.TryParse(args[1], out lineCount);
					Int32.TryParse(args[2], out fileCount);
					outputFileName = args[3];
					fileAttrib = args[4];
					StreamReader sr = new StreamReader(fileName);


					for (int i = 0; i < fileCount; i++)
					{
						fileName = outputFileName + i + fileAttrib;
						Console.WriteLine("Work with {0}", fileName);
						FileStream fs = new FileStream(fileName, FileMode.Create);
						while (a <= lineCount && (buff = sr.ReadLine()) != null)
						{
							fs.Write(Encoding.UTF8.GetBytes(buff + "\n"));
							a++;
						}
						a = 0;
					}
					Console.WriteLine("Press any key to exite.");
					Console.ReadKey();
				}
				else throw new Exception("Enter the arguments");

			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: {0}", ex.ToString());
			}

		}
	}
}
