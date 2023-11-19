using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint5.Task1.V20.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task1.V20
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
			Console.WriteLine("* Задание #1                                                                 *");
			Console.WriteLine("* Вариант #20                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Вычислить выражение и сохранить результат в текстовый файл                 *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int startValue = -5;
			int stopValue = 5;
			Console.WriteLine("StartValue = -5");
			Console.WriteLine("StopValue = 5");

			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			string res = ds.SaveToFileTextData(startValue, stopValue);

			Console.WriteLine("Файл: " + res);
			Console.WriteLine("Создан!");
			Console.ReadKey();
		}
	}
}
