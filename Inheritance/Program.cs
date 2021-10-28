using System;
using Inheritance.Models;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //var obj1 = new
            //{
            //    name = "Orkhan",
            //    surname = "Ganbarov",
            //    age = 19
            //};
            //Console.WriteLine(obj1.name + " " + obj1.surname + " " + obj1.age);
            //Console.WriteLine("{0} {1} {2}", obj1.name, obj1.surname, obj1.age);
            //Console.WriteLine($"{ obj1.name} { obj1.surname} { obj1.age}");
            University uni1 = new University("AzTU", "Huseyn Javid 25");
            University uni2 = new University("ATU", "Samad Vurgun", 6,"Orkhan");
            University uni3 = new University();
            Faculty fak1 = new Faculty();
            Faculty fak2 = new Faculty("Neqliyyat", 5);
            Faculty fak3 = new Faculty("XTQ", 2, "Orxan", "Xususi Teyinatli Q.", 5);
            //uni1.name = "AzTU";
            //uni1.location = "Huseyn Javid 25";
            //uni1.body_numbers = 8;
            //Console.WriteLine(uni1.name); 
            //Console.WriteLine(uni1.location); 
            //Console.WriteLine(uni1.body_numbers);
           // University uni1 = new University();
            uni1.Information();  
            uni2.Information();  
            uni3.Information();
            fak1.Information();
            fak2.Information();    
        }
    }
   
}
