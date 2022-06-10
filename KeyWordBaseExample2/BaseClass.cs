using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWordBaseExample2
{
	internal class BaseClass
	{
		int num;

		public BaseClass()
		{
			Console.WriteLine("in BaseClass()");
		}

		public BaseClass(int i)
		{
			num = i;
			Console.WriteLine("in BaseClass(int i)");
		}

		public int GetNum()
		{ return num; }
	}
}
