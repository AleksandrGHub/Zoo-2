﻿namespace Zoo_2
{
    class LionFactory : Factory
    {
        public override Animal Create()
        {
            return new Animal(type: "Львы", sound: "Р-р-р-р-р!");
        }
    }
}