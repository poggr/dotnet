//using System;

//namespace ConstructorExample
//{
//    public class Person
//    {
//        // Fields
//        public string Name;
//        public int Age;

//        // Default Constructor
//        public Person()
//        {
//            Name = "Aria";
//            Age = 0;
//            Console.WriteLine("\nDefault Constructor Called");
//        }

//        // Parameterized Constructor
//        public Person(string name, int age)
//        {
//            Name = name;
//            Age = age;
//            Console.WriteLine("\nParameterized Constructor Called");
//        }

//        // Copy Constructor
//        //public Person(Person other)
//        //{
//        //    Name = other.Name;
//        //    Age = other.Age;
//        //    Console.WriteLine("Copy Constructor Called");
//        //}

//        // Static Constructor
//        static Person()
//        {
//            Console.WriteLine("Static Constructor Called");
//        }

//        // Method to display details
//        public void DisplayDetails()
//        {
//            Console.WriteLine($"Name: {Name}, Age: {Age}");
//        }
//    }

//    class Program
//    {
//        // Main method must be static
//        static void Main(string[] args)
//        {
//            // Static constructor is called only once when the class is first used
            
//            Person person1 = new Person();  // Calls default constructor
//            person1.DisplayDetails();

//            //Console.WriteLine("\nCreating Person2 using Parameterized Constructor:");
//            Person person2 = new Person("John", 30);  // Calls parameterized constructor
//            person2.DisplayDetails();

//            //Console.WriteLine("\nCreating Person3 using Copy Constructor:");
//            //Person person3 = new Person(person2);  // Calls copy constructor
//            //person3.DisplayDetails();
//        }
//    }
//}
