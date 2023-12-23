using System;

namespace Zoo_2
{
    class Menu
    {
        private const string LookLionCommand = "lion";
        private const string LookBearCommand = "bear";
        private const string LookHorseCommand = "horse";
        private const string LookTigerCommand = "tiger";
        private const string LookElephantCommand = "elephant";
        private const string ExitCommand = "exit";

        private Zoo _zoo = new Zoo();

        public void Work()
        {
            string userInput;

            _zoo.AddAnimals();

            do
            {
                Console.Clear();
                Show();

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case LookLionCommand:
                        _zoo.ShowAviary(0);
                        break;

                    case LookBearCommand:
                        _zoo.ShowAviary(1);
                        break;

                    case LookHorseCommand:
                        _zoo.ShowAviary(2);
                        break;

                    case LookTigerCommand:
                        _zoo.ShowAviary(3);
                        break;

                    case LookElephantCommand:
                        _zoo.ShowAviary(4);
                        break;
                }
            } while (userInput != ExitCommand);
        }

        private void Show()
        {
            Console.WriteLine("**********************Меню**********************");
            Console.WriteLine($"Посмотреть вольер со львами     (команда: {LookLionCommand})");
            Console.WriteLine($"Посмотреть вольер с медведями   (команда: {LookBearCommand})");
            Console.WriteLine($"Посмотреть вольер с лошадьми   (команда: {LookHorseCommand})");
            Console.WriteLine($"Посмотреть вольер с тиграми   (команда: {LookTigerCommand})");
            Console.WriteLine($"Посмотреть вольер со слонами   (команда: {LookElephantCommand})");
            Console.WriteLine($"Выйти                           (команда: {ExitCommand})");
        }
    }
}
