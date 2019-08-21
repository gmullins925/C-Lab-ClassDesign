using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab_ClassDesign
{
	class Dog
	{

		String name;
		String breed;
		int age;

		public Dog(string name, string breed, int age)
		{
			this.Name = name;
			this.Breed = breed;
			this.Age = age;
		}

		public string Name { get => name; set => name = value; }
		public string Breed { get => breed; set => breed = value; }
		public int Age { get => age; set => age = value; }
	}
}
