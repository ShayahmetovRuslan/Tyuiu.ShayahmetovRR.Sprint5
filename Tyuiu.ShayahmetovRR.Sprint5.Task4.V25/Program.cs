using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint5.Task4.V25.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task4.V25
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			Console.Title = "Спринт #5 | Выполнил: Шаяхметов Р.Р | АСОиУб 23-1";
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* Спринт #5                                                                  *");
			Console.WriteLine("* Тема: Обработка файлов                                                     *");
			Console.WriteLine("* Задание #3                                                                 *");
			Console.WriteLine("* Вариант #26                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Вычислить значение выражения и сохранить в bin файл                        *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V25.txt";

			Console.WriteLine("Данные находятся в файле: " + path);

			Console.WriteLine("\n\n******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			double res = ds.LoadFromDataFile(path);
			Console.WriteLine(res);
			Console.ReadKey();
		}
	}
}
