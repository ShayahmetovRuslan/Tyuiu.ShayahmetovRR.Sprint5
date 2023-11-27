using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint5.Task7.V2.Lib;
using System.IO;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task7.V2
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
			Console.WriteLine("* Задание #7                                                                 *");
			Console.WriteLine("* Вариант #2                                                                 *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Прочитать txt файл и заменить в нем все цифры на '#'                       *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V2.txt";

			Console.WriteLine("Данные находятся в файле: " + path);

			Console.WriteLine("\n\n******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			string res = ds.LoadDataAndSave(path);
			Console.WriteLine(res);
			Console.ReadKey();
		}
	}
}
