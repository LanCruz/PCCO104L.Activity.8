using System.Security.Cryptography.X509Certificates;

namespace PCCO104L.Activity._8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Man kakashi = new Man("Kakashi", "Sharingan shop");
            kakashi.Name = "Kakashi";
            kakashi.Business = "Sharingan Shop";
            kakashi.Shop();

            Doctor strange = new Doctor("Dr. Strange", "New York hospital");
            strange.Contact = 911;
            strange.Work();

            Nurse percy = new Nurse("Percy", "New York Hospital");
            percy.Contact = 911;
            percy.Work();
            percy.Caring();

            Doctor stephen = new Nurse("Stephen", "New York Hospital");
            stephen.Contact = 911;
            stephen.Work();
        }
    }

    public abstract class Student
    { 
        public string Name { get; set; }

        protected Student()
        {
            Console.WriteLine("All good in Constructor");
        }

        protected Student(string name)
        {
            Name = name;
        }

        private void University()
        {
            Console.WriteLine($"Hello I'm {Name}");
        }
    }


    public class Man: Student
    {
        public string Business { get; set; }

        public Man(string name, string business) : base(name)
        {
            Business = business;
        }   

        public void Shop()
        {
            Console.WriteLine($"{Name} selling eye in {Business}");
        }
    }


    public class Doctor: Student
    {
        public double Contact { get; set; }
        public string Hospital { get; set; }

        public Doctor(string name, string hospital) : base(name)
        {
            Hospital = hospital;
        }


        public void Work()
        {
            Console.WriteLine($"I'm {Name} I work at {Hospital} call {Contact} if need help");
        }
    }

    public class Nurse : Doctor
    {
        public Nurse(string name,string hospital) : base(name, hospital)
        {
            Hospital = hospital;
        }
        public void Caring()
        { 
            Console.WriteLine($"{Name} is a nurse caring at {Hospital}");
        }
    }




}
