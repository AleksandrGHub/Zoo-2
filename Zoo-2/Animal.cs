using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Zoo_2
{
    class Animal
    {
        private RNGCryptoServiceProvider _random = new RNGCryptoServiceProvider();

        private List<string> _genders = new List<string>()
        {
            "Male",
            "Female"
        };

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
            int firstIndex = 0;
            int secondIndex = 1;

            string gender;

            if (GetRandomNumber() % divisor == remainder)
            {
                gender = _genders[firstIndex];
            }
            else
            {
                gender = _genders[secondIndex];
            }

            return gender;
        }

        private int GetRandomNumber()
        {
            byte[] randomNumber = new byte[4];
            _random.GetBytes(randomNumber);
            int number = BitConverter.ToInt32(randomNumber, 0);
            return number;
        }
    }
}