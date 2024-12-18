//using System;

//// Base class
//class Animal
//{
//    public void Eats()
//    {
//        Console.WriteLine("Animal eats food.");
//    }

//    public void Sleeps()
//    {
//        Console.WriteLine("Animal sleeps.");
//    }
//}

//// Multilevel Inheritance (Dog -> Puppy)
//class Dog : Animal
//{
//    public void Barks()
//    {
//        Console.WriteLine("Dog barks.");
//    }
//}

//class Puppy : Dog
//{
//    public void Play()
//    {
//        Console.WriteLine("Puppy plays.");
//    }
//}

//// Hierarchical Inheritance (Cat -> Animal, Dog -> Animal)
//class Cat : Animal
//{
//    public void Meows()
//    {
//        Console.WriteLine("Cat meows.");
//    }
//}

//// Interface
//interface ICanSwim
//{
//    void Swim();
//}


//// Hybrid Inheritance using interfaces (Human class inheriting from Animal class and implementing interfaces)
//class Human : Animal, ICanSwim 
//{ 
//    public void Speak()
//    {
//        Console.WriteLine("Human speaks.");
//    }

//    // Implementing interface methods
//    public void Swim()
//    {
//        Console.WriteLine("Human can swim.");
//    }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Demonstrating Multilevel Inheritance
//        Puppy puppy = new Puppy();
//        puppy.Eats();    // Inherited from Animal
//        puppy.Sleeps();  // Inherited from Animal
//        puppy.Barks();   // Inherited from Dog
//        puppy.Play();    // Specific to Puppy

//        Console.WriteLine(); // New Line for better formatting

//        // Demonstrating Hierarchical Inheritance
//        Dog dog = new Dog();
//        dog.Eats();   // Inherited from Animal
//        dog.Barks();  // Specific to Dog

//        Console.WriteLine();

//        Cat cat = new Cat();
//        cat.Eats();   // Inherited from Animal
//        cat.Meows();  // Specific to Cat

//        Console.WriteLine();

//        // Demonstrating Hybrid Inheritance using Interfaces
//        Human human = new Human();
//        human.Eats();  // Inherited from Animal
//        human.Swim();  // Implemented from ICanSwim interface
//        human.Speak(); // Specific to Human
//    }
//}
