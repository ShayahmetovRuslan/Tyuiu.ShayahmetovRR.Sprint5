using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint5.Task6.V16.Lib;
using System.IO;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task6.V16
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
			Console.WriteLine("* Задание #6                                                                 *");
			Console.WriteLine("* Вариант #16                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Посчитать все английские слова в txt файле                                 *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask6V16.txt";

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
