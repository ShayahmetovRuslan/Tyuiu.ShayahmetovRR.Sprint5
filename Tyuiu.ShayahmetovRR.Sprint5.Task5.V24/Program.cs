using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint5.Task5.V24.Lib;
using System.IO;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task5.V24
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
			Console.WriteLine("* Задание #5                                                                 *");
			Console.WriteLine("* Вариант #24                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Прочитать значения из txt файла и найти сумму всех двузначных целых чисел  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V24.txt";

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
