using System;

namespace TestLesson.Animals
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        
    }
}