using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task6.V16.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			string path = @"C:\Users\zorg0\source\repos\Tyuiu.ShayahmetovRR.Sprint5\Tyuiu.ShayahmetovRR.Sprint5.Task6.V16\bin\Debug\InPutDataFileTask6V16.txt";

			FileInfo fileInfo = new FileInfo(path);

			bool fileExists = fileInfo.Exists;
			bool wait = true;

			Assert.AreEqual(wait, fileExists);
		}
	}
}
