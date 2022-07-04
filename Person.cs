using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaliySmuk_HomeWork_4
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        private int birthYear;
        public int BirthYear
        {
            get { return birthYear; }
        }
        public Person()
        {

        }
        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
        public static Person Input(int i)
        {
            Console.WriteLine($"Enter {i + 1} person Name");
            string name = Console.ReadLine();
            name = name.ToUpper();
            Console.WriteLine($"Enter {i + 1} person Year of birth");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Person person1 = new Person(name, birthYear);
            return person1;
        }
        public void Age()
        {
            int age = (DateTime.Now.Year - birthYear);
            Console.WriteLine($"he/she is {age} years old");
        }
        public void ChangeName()
        {
            if (DateTime.Now.Year - birthYear < 16)
                name = "Very Young";
        }
        public override string ToString()
        {
            return $"\n His/her name is {name} he/she born in {birthYear}";
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator ==(Person first, Person second)
        {
            return (first.name == second.name);
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first.name == second.name);
        }
    }
}