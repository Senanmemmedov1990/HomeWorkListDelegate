using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLinkedlistDelegate
{
    internal class Student : Human
    {
        public int Grade { get; set; }

        public Student(string name, int grade) : base(name)
        {
            Grade = grade;
        }
    }
}
