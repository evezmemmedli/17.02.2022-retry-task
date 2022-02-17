using System;

namespace _17._02._2022_retry_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Students student = new Students("Avaz", "Mammadli", "p127", 95, true);
            Console.WriteLine(student.GetFullname());
            Console.WriteLine(student.GetInfo());
            Students student1 = new Students("Eli", "Veliyev", "p127", 44, false);
            Console.WriteLine(student1.GetFullname());
            Console.WriteLine(student1.GetInfo());
            Students student2 = new Students("Akif", "Musayev", "p127", 82, true);
            Console.WriteLine(student2.GetFullname());
            Console.WriteLine(student2.GetInfo());

        }
    }
    class Students
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;
        public Students(string name, string surname, string group, int point, bool isGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = isGraduated;
        }
        public string GetFullname()
        {
            return Name + " " + Surname;
        }
        public string GetInfo()
        {
            string graduatedInfo = " Not Graduated";
            //string graduationInfo = IsGraduated ? "Graduated" : "Not graduated.";
            if (IsGraduated)
            {
                graduatedInfo = "Graduated";
            }
            string examStatus = CanBeJoinToExam().ToString();

            return @$"
                   Name:{Name}
                   Surname: {Surname}
                   Group:{Group}
                   Point:{Point} 
                   IsGraduated : {graduatedInfo}
                   CanBeEnterExam : {examStatus}";
        }
        public bool CanBeJoinToExam()
        {
            return Point > 80;
        }
    }
}
