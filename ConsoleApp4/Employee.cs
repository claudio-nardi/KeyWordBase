using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	internal class Employee : Person
	{
		public string id = "ASSFFD#D";

		public override void GetInfo()
		{
			base.GetInfo();
			Console.WriteLine("Employee ID: {0}", id);
		}


	}
}
