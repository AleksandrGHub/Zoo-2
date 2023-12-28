using System;
using System.Collections.Generic;

namespace Zoo_2
{
    class Zoo
    {
        private Random _random = new Random();

        private List<Aviary> _aviarys = new List<Aviary>();

        public Zoo()
        {
            AddAnimals();
        }

        public void ShowAviary(int index)
        {
            _aviarys[index].ShowInfo();
            Console.ReadKey();
        }

        private void AddAnimals()
        {
            int minNumberAnimals = 5;
            int maxNumberAnimals = 10;
            int numberAnimals;

            List<Factory> factorys = new List<Factory>()
            {
                new LionFactory(),
                new BearFactory(),
                new HorseFactory(),
                new TigerFactory(),
                new ElephantFactory()
            };

            Aviary aviary;

            for (int i = 0; i < factorys.Count; i++)
            {
                aviary = new Aviary();

                numberAnimals = _random.Next(minNumberAnimals, maxNumberAnimals);

                for (int j = 0; j < numberAnimals; j++)
                {
                    aviary.AddAnimal(factorys[i].Create());
                }

                _aviarys.Add(aviary);
            }
        }
    }
}