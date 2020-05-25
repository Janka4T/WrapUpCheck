using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapUpCheck
{
    class Program
    {       
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add (new Student());
            students[0].Name = "Jariks";
            students[0].Surname = "Real";
            students[0].Age = 16;
            students[0].Grade = 8;
            students[0].ChangeSchool("JA");

            students.Add(new Student());
            students[1].Name = "Lers";
            students[1].Surname = "Mikey";
            students[1].Age = 15;
            students[1].Grade = 6;
            students[1].ChangeSchool("Nes");

            students.Add(new Student());
            students[2].Name = "Jackey";
            students[2].Surname = "Hig";
            students[2].Age = 31;
            students[2].Grade = 7;
            students[2].ChangeSchool("Sk8 School");

            students.Add(new Student());
            students[3].Name = "Babatunde";
            students[3].Surname = "Kooe";
            students[3].Age = 3;
            students[3].Grade = 10;
            

            foreach(Student s in students)
            {
                Console.WriteLine(s.Name + " is from "+ s.School);                
            }
            Console.ReadKey();
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public string School { get; private set; } = "Unknown";

        public Student()
        {
            Console.Write("Hi, I am Created!\n");
            Console.ReadKey();
        }

        public void ChangeSchool(string schoolName)
        {
            if(schoolName != "Datorium" && schoolName != "Sk8 School" && schoolName != "JA")
            {
                Console.WriteLine("Use only Authorised School's!");
            }
            else
            {
                this.School = schoolName;
            }
        }
    }
}
