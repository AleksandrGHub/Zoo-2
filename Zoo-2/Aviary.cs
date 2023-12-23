using System;
using System.Collections.Generic;

namespace Zoo_2
{
    class Aviary
    {
        private List<Animal> _animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"В вольере находится {_animals[0].Type}, {_animals.Count} особей");

            foreach (var animal in _animals)
            {
                Console.WriteLine($"{animal.Gender}  издаёт звук: {animal.Sound}");
            }
        }
    }
}