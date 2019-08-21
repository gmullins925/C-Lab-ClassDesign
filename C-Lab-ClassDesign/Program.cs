using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab_ClassDesign
{
	class Program
	{
		static void Main(string[] args)
		{
			Class1 chem101 = new Class1(101, "Intro to Chemistry", "Smith");
			Console.WriteLine(chem101.ToString());
			Console.ReadLine();

			Dog tuffy = new Dog("tuffy", "poodle", 5);
			Console.WriteLine(tuffy.ToString());
			Console.ReadLine();
		}
	}
}
