using System.Diagnostics;
using System.Xml.Linq;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            PostGraduate pg = new PostGraduate {  ThesisTopic = "AI in Healthcare" };
            pg.Name = "Fares";
            pg.Age = 20;
            pg.Grade = 90;
            pg.PrintDetails();

            Employee emp = new Employee { Name = "Fares", Gender = 'M', Id = 100, Salary = 1_00_00, Security = SecurityLevel.Developer };
            Console.WriteLine(emp);
        }
    }
    class Student
    {
        public int Age { get; set; }
        public int Grade { get; set; }
        public string Name { get; set; }
        public void PrintDetails()
        {
            Console.WriteLine($"MyName is {Name} - Age is {Age} - Grade:{Grade}");
        }
    }
    class PostGraduate : Student
    {
        public string ThesisTopic { get; set; }
        public virtual void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine(ThesisTopic);
        }
    }
    class Employee
    {
        char gender;
        public string Name { get; set; }
        public char Gender
        {
            get => gender;
            set
            {
                if (value == 'F' || value == 'M')
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'");
            }
        }
        public int Id { get; set; }
        public double Salary { get; set; }
        public SecurityLevel Security { get; set; }
        public override string ToString()
        {
            return String.Format($"Name:{Name} - Gender:{gender} - Id:{Id} - Salary {Salary:c} - SecurityLevel:{Security}");
        }
    }
    enum SecurityLevel
    {
        uest,
        Developer,
        secretary,
        DBA
    }
}
