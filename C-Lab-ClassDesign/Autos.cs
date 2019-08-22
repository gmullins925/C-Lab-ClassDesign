using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab_ClassDesign
{
	class Autos
	{
		int year;
		string make;
		string model;

		public Autos(int year, string make, string model)
		{
			this.Year = year;
			this.Make = make;
			this.Model = model;
		}

		public int Year { get => year; set => year = value; }
		public string Make { get => make; set => make = value; }
		public string Model { get => model; set => model = value; }
	}
}
