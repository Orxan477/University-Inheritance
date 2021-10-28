using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Models
{
    class University:Student
    {
        public string name;
        public string location;
        public int body_numbers;

        public University():this("BDU","Elmler",5)
            {
            Console.WriteLine("Universty's page created");
            }
        public University(string name):base("Default(Orkhan)")
        {
            this.name = name;
        }

        public University(string name,string location):this(name)
        {
            //name = University_Name;
            this.location = location;
        }
        public University(string name, string location,int body) :this(name,location)
        {
           
          //  this.location = location;
            this.body_numbers = body;
        }
        public University(string name, string location, int body,string str_name) : this(name, location,body)
        {

            //  this.location = location;
            // this.body_numbers = body;
            this.student_name = str_name;
        }
        public void Information()
        {
            Console.WriteLine($"University name: {name} \nUniversity location: {location} \nUniversity body numbers: {body_numbers} \nStudent Name: {student_name}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        }
    }
}
