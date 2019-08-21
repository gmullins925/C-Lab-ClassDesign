using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab_ClassDesign
{
	class Class1
	{
		int courseID;
		string courseName;
		string teacher;

		public Class1(int courseID, string courseName, string teacher)
		{
			this.CourseID = courseID;
			this.CourseName = courseName;
			this.teacher = teacher;
		}

		public int CourseID { get => courseID; set => courseID = value; }
		public string CourseName { get => courseName; set => courseName = value; }
		public string Teacher { get => teacher; set => teacher = value; }
	}
}
