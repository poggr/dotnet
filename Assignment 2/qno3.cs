//using System;

//namespace PartialClassExample
//{
//    // Part 1 of the partial class
//    public partial class Person
//    {
//        // Field to store the name
//        public string Name { get; set; }

//        // Method to display the name
//        public void DisplayInfo()
//        {
//            Console.WriteLine("Name: " + Name);
//        }
//    }

//    // Part 2 of the partial class
//    public partial class Person
//    {
//        // Field to store the age
//        public int Age { get; set; }

//        // Method to display the age
//        public void DisplayAge()
//        {
//            Console.WriteLine("Age: " + Age);
//        }
//    }

//    // Part 3 of the partial class
//    public partial class Person
//    {
//        // Method to display a greeting
//        public void DisplayGreeting()
//        {
//            Console.WriteLine("Hello, " + Name + "!");
//        }
//    }

//    // Main Program
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Creating an instance of the partial class 'Person'
//            Person person = new Person();
//            person.Name = "John";
//            person.Age = 30;

//            // Displaying the person's info and age
//            person.DisplayInfo();
//            person.DisplayAge();
//            person.DisplayGreeting();
//        }
//    }
//}
