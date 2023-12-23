using System;
using System.Collections.Generic;

namespace Zoo_2
{
    class Zoo
    {
        private int _minNumberAnimals = 5;
        private int _maxNumberAnimals = 10;

        private Random _random = new Random();

        private List<Aviary> _aviarys = new List<Aviary>();
        private List<Factory> _factorys = new List<Factory>()
        {
            new LionFactory(),
            new BearFactory(),
            new HorseFactory(),
            new TigerFactory(),
            new ElephantFactory()
        };

        public void AddAnimals()
        {
            int numberAnimal;

            Aviary aviary;

            for (int i = 0; i < _factorys.Count; i++)
            {
                aviary = new Aviary();
                numberAnimal = _random.Next(_minNumberAnimals, _maxNumberAnimals);

                for (int j = 0; j < numberAnimal; j++)
                {
                    aviary.AddAnimal(_factorys[i].Create());
                }

                _aviarys.Add(aviary);
            }
        }

        public void ShowAviary(int index)
        {
            _aviarys[index].ShowInfo();
            Console.ReadKey();
        }
    }
}