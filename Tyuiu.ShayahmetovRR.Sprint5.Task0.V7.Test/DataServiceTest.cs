using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task0.V7.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void CheckedExistsFile()
		{
			string path = @"C:\Users\zorg0\source\repos\Tyuiu.ShayahmetovRR.Sprint5\Tyuiu.ShayahmetovRR.Sprint5.Task0.V7\bin\Debug\OutPutFileTask0.txt";

			FileInfo fileInfo = new FileInfo(path); 

			bool fileExists = fileInfo.Exists;
			bool wait = true;

			Assert.AreEqual(wait, fileExists);
		}
	}
}
