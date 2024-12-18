////a virtual method is a method in a base class that can be overridden in a derived class using the override
//using System;

//namespace VirtualMethodExample
//{
//    public class Animal
//    {
//        // Virtual method
//        public virtual void Speak()
//        {
//            Console.WriteLine("The animal makes a sound.");
//        }
//    }

//    public class Dog : Animal
//    {
//        // Override the virtual method
//        public override void Speak()
//        {
//            Console.WriteLine("The dog barks.");
//        }
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            // Creating an object of the base class
//            Animal myAnimal = new Animal();
//            myAnimal.Speak();

//            // Creating an object of the derived class
//            Dog myDog = new Dog();
//            myDog.Speak();

//            // Using polymorphism: Animal reference, but Dog object
//            Animal polymorphicAnimal = new Dog();
//            polymorphicAnimal.Speak();
//        }
//    }
//}
