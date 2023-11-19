using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint5.Task0.V7.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task0.V7
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
			Console.WriteLine("* Задание #0                                                                 *");
			Console.WriteLine("* Вариант #7                                                                 *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Вычислить выражение и сохранить результат в текстовый файл                 *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int x = 4;
			Console.WriteLine("x = ", x);
			
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			string res = ds.SaveToFileTextData(x);

			Console.WriteLine("Файл: " + res);
			Console.WriteLine("Создан!");
			Console.ReadKey();
		}
	}
}
