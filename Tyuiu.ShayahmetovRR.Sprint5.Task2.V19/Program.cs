using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint5.Task2.V19.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task2.V19
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
			Console.WriteLine("* Задание #2                                                                 *");
			Console.WriteLine("* Вариант #19                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Совершить взаимодействие с матрицей и добавить в таблицу                   *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int[,] matrix = new int[3, 3] { { 9, 2, 5 },
											{ 8, 8, 2 },
											{ 7, 4, 8 } };
			int rows = matrix.GetUpperBound(0) + 1;
			int cols = matrix.GetUpperBound(1) + 1;

			Console.WriteLine("Массив:");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("\n");
				for (int j = 0; j < cols; j++)
				{
					Console.Write($"{matrix[i, j]} ");
				}
			}

			Console.WriteLine("\n\n******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			string res = ds.SaveToFileTextData(matrix);

			Console.WriteLine("Файл: " + res);
			Console.WriteLine("Создан!");
			Console.ReadKey();
		}
	}
}
