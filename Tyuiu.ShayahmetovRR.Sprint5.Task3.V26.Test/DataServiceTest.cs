using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task3.V26.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void CheckExistsFile()
		{
			string path = @"C:\Users\zorg0\source\repos\Tyuiu.ShayahmetovRR.Sprint5\Tyuiu.ShayahmetovRR.Sprint5.Task3.V26\bin\Debug\OutPutFileTask3.bin";

			FileInfo fileInfo = new FileInfo(path);

			bool fileExists = fileInfo.Exists;
			bool wait = true;

			Assert.AreEqual(wait, fileExists);
		}
	}
}
