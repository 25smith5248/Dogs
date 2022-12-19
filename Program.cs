/*
 * Program Name: Dog creator
 * Programmer: Trent Smith
 * Date: 12/19/2022
 *
 * Description: tells you list of dog names? Be sure
 * to keep everything within view on your screen. Edit
 * this description to match what your program does. For
 * example, "This program allows users to create new
 * users in a C# windows console application
 */

using System;
using System.Collections.Generic;

namespace DogExample
{
    // This is the Dog class. It has two properties: Name and Breed.
    class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        // This is the constructor for the Dog class. It takes two arguments:
        // the name and breed of the dog.
        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new List of Dogs.
            List<Dog> dogs = new List<Dog>();

            // Add some dogs to the list.
            dogs.Add(new Dog("knight", "Golden Retriever"));
            dogs.Add(new Dog("Jax", "Beagle"));
            dogs.Add(new Dog("spoon", "German Shepherd"));

            // Loop through the list of dogs and print their names and breeds.
            foreach (Dog dog in dogs)
            {
                Console.WriteLine($"{dog.Name} is a {dog.Breed}.");
            }
        }
    }
}