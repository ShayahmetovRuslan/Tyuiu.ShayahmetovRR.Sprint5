﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task3.V26.Lib
{
	public class DataService : ISprint5Task3V26
	{
		public string SaveToFileTextData(int x)
		{
			string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

			double z = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);

			z = Math.Round(z, 3);

			using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
			{
				writer.Write(BitConverter.GetBytes(z));
			}

			return path;
		}
	}
}
