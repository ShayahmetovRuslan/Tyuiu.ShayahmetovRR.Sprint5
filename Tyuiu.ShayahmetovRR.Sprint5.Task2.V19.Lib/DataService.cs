﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.ShayahmetovRR.Sprint5.Task2.V19.Lib
{
	public class DataService : ISprint5Task2V19
	{
		public string SaveToFileTextData(int[,] matrix)
		{
			string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";

			FileInfo fileInfo = new FileInfo(path);
			bool fileExists = fileInfo.Exists;

			if (fileExists)
			{
				File.Delete(path);
			}

			int rows = matrix.GetUpperBound(0) + 1;
			int cols = matrix.Length / rows;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (matrix[i, j] % 2 == 1)
					{
						matrix[i, j] = 0;
					}
				}
			}
			string str = "";

			for (int i = 0; i < rows;  ++i)
			{
				for (int j = 0;j < cols; ++j)
				{
					if (j != cols - 1)
					{
						str += matrix[i, j] + ";";
					}
					else
					{
						str += matrix[i, j];
					}
				}

				if (i != rows - 1)
				{
					File.AppendAllText(path, str + Environment.NewLine);
				}
				else
				{
					File.AppendAllText(path, str);
				}
				str = "";
			}

			return path;
		}
	}
}
