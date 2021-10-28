using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Models
{
    class Faculty:Student
    {
        public string name;
        public int number_of_specialties;
        
        public Faculty():this("ITT",7,"Orkhan Ganbarov","Computer Sciences",5)
        {
            Console.WriteLine("Faculty's page created");
        }
        public Faculty(string name):base("Default(Tural)")
        {
            this.name = name;
        }

        public Faculty(string name, int number_of_specialties) : this(name)
        {
            //name = University_Name;
            this.number_of_specialties =  number_of_specialties;
        }
        public Faculty(string name, int number_of_specialties,string student_name) : this(name,number_of_specialties) 
        {
            //name = University_Name;
            //this.number_of_specialties = number_of_specialties;
            this.student_name = student_name;
        }
        public Faculty(string name, int number_of_specialties, string student_name,string specality,int num_cr) : this(name, number_of_specialties,student_name)
        {
            //name = University_Name;
            //this.number_of_specialties = number_of_specialties;
            //this.student_name = str_name;
            this.specality = specality;
            this.num_credit = num_cr;
        }
        public void Information()
        {
            Console.WriteLine($"Faculty name: {name} \nNumber of Specialties: {number_of_specialties} \nStudent Name: {student_name} \nSpeciality Name: {specality} \nNumber of Credit Name: {num_credit}");
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}
