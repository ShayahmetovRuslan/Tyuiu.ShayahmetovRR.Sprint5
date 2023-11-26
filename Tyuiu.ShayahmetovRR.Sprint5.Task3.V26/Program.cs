using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint5.Task3.V26.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task3.V26
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

			int x = 2;
			Console.WriteLine("x = 2");

			Console.WriteLine("\n\n******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			string res = ds.SaveToFileTextData(x);

			Console.WriteLine("Файл: " + res);
			Console.WriteLine("Создан!");
			Console.ReadKey();
		}
	}
}
