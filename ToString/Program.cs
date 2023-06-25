using System;

namespace ToString
{
    public class Person
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Age { get; set; }
        private double Weight { get; set; }
        private double Height { get; set; }
        public Person(string name, string surname, int age, double weight, double height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nWeight: {Weight}\nHeight: {Height}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Ali","Salmanov",20,69,1.75);
            Console.WriteLine(person);
        }
    }
}
