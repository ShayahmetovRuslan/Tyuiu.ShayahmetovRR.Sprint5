using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.ShayahmetovRR.Sprint5.Task5.V24.Lib
{
	public class DataService : ISprint5Task5V24
	{
		public double LoadFromDataFile(string path)
		{
			double res = 0;
			using (StreamReader reader = new StreamReader(path))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					if ((Convert.ToDouble(line) >= 10 || Convert.ToDouble(line) <= -10) && (Convert.ToDouble(line) == Math.Truncate(Convert.ToDouble(line))))
					{
						res += (Convert.ToDouble(line));
					}
				}
			}
			return res;
		}
	}
}
