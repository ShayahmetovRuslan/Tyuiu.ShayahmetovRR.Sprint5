using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task7.V2.Lib
{
	public class DataService : ISprint5Task7V2
	{
		public string LoadDataAndSave(string path)
		{
			string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V2.txt";
			string line;

			FileInfo fileInfo = new FileInfo(pathSaveFile);
			bool fileExists = fileInfo.Exists;

			if (fileExists)
			{
				File.Delete(pathSaveFile);
			}

			using (StreamReader reader = new StreamReader(path))
			{
				char[] numbers = { '1', '2', '3', '4', '5', '6' };
				while ((line = reader.ReadLine()) != null)
				{
					for (int i = 0; i < line.Length; i++)
					{
						foreach (char c in numbers)
						{
							if (c == line[i])
							{
								line = line.Replace(c, '#');
							}
						}
					}

					File.AppendAllText(pathSaveFile, line + Environment.NewLine);
				}
			}
			return pathSaveFile;
		}
	}
}
