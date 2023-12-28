using System;
using System.Security.Cryptography;

namespace Zoo_2
{
    class Animal
    {
        private RNGCryptoServiceProvider _cryptoServiceProvider = new RNGCryptoServiceProvider();

        public Animal(string type, string sound)
        {
            Type = type;
            Sound = sound;
            Gender = GetGender();
        }

        public string Type { get; private set; }
        public string Sound { get; private set; }
        public string Gender { get; private set; }

        private string GetGender()
        {
            int divisor = 2;
            int remainder = 0;

            string firstGender = "Male";
            string secondGender = "Female";

            return GetRandomNumber() % divisor == remainder ? firstGender : secondGender;
        }

        private int GetRandomNumber()
        {
            byte[] randomNumbers = new byte[4];

            _cryptoServiceProvider.GetBytes(randomNumbers);

            return BitConverter.ToInt32(randomNumbers, 0);
        }
    }
}