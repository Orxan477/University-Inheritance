using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Models
{
    class Student
    {
        public string student_name;
        public string specality;
        public int num_credit;

        public Student(string student)
            {
            student_name = student;
            }
        public Student(string student,string specality,int num_credit):this(student)
        {
            this.specality=specality;
            this.num_credit = num_credit;
        }
    }
}
