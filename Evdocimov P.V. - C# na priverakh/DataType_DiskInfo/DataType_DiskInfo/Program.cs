using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Book_Evdocimov___eg
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Значение 123456 в разных форматах:");
			Console.WriteLine("d7: {0:d7}", 123456);
			Console.WriteLine("c: {0:c}", 123456);
			Console.WriteLine("n: {0:n}", 123456);
			Console.WriteLine("f3: {0:f3}", 123456);

			Console.WriteLine();
			string sTemp = string.Format($"n: {123456:n}");
			Console.WriteLine($"sTemp: {sTemp} ");

			Console.WriteLine();
			Console.WriteLine("int.MaxValue:" + int.MaxValue);
			Console.WriteLine("int.MinValue:" + int.MinValue);

			Console.WriteLine();
			Console.WriteLine("double.Epsilon: " + double.Epsilon);
			Console.WriteLine("double.MaxValue: " + double.MaxValue);
			Console.WriteLine("double.MinValue: " + double.MinValue);
			Console.WriteLine("double.NegativeInfinity: " + double.NegativeInfinity);
			Console.WriteLine("double.PositiveInfinity: " + double.PositiveInfinity);
			Console.WriteLine("double.NaN: " + double.NaN);

			Console.WriteLine();
			Console.WriteLine($"TrueString {bool.TrueString}");
			Console.WriteLine($"FalseString {bool.FalseString}");

			Console.WriteLine();
			Console.WriteLine("char.MaxValue: " + char.MaxValue);
			Console.WriteLine("char.MaxValue: " + char.MinValue);

			Console.WriteLine();
			char cTemp = '1';
			do
			{
				Console.WriteLine($"IsDigit == \'{cTemp}\' : {char.IsDigit(cTemp)}");
				Console.WriteLine($"IsWhiteSpace == \'{cTemp}\' : {char.IsWhiteSpace(cTemp)}");
				Console.WriteLine($"IsPunctuation == \'{cTemp}\' : {char.IsPunctuation(cTemp)}");

				if (cTemp == '.') break;
				if (cTemp == ' ') cTemp = '.';
				if (cTemp == '1') cTemp = ' ';
			} while (true);


			Console.WriteLine();
			Console.WriteLine("short.MaxValue: " + short.MaxValue);
			short a = 20000, b = 10000, c = 20000;

			try
			{
				short r = checked((short)Add(a, b));
				Console.WriteLine("c = {0}", r);
				r = checked((short)Add(a, c));
				Console.WriteLine("c = {0}", r);
			}
			catch (OverflowException ex)
			{
				Console.WriteLine(ex.Message);
			}



			// Изменяем кодировку консоли для вывода текста
			Console.OutputEncoding = Encoding.GetEncoding(866);
			Console.WriteLine("Ваши диски:");
			string[] drives = Directory.GetLogicalDrives();

			foreach (string s in drives)
				Console.WriteLine("{0}", s);
			DriveInfo[] drvs = DriveInfo.GetDrives();

			foreach (DriveInfo d in drvs)
			{
				Console.WriteLine("Диск: {0} Тип {1}", d.Name, d.DriveType);
				if (d.IsReady)
				{
					Console.WriteLine("Свободно: {0}", d.TotalFreeSpace);
					Console.WriteLine("Файловая система: {0}", d.DriveFormat);
					Console.WriteLine("Метка: {0}", d.VolumeLabel);
					Console.WriteLine();
				}
			}



			Console.ReadKey();
		}

		static int Add(int a, int b)
		{
			return a + b;
		}
	}
}
