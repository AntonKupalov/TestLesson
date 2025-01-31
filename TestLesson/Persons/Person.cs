using System;

namespace TestLesson.Persons
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}