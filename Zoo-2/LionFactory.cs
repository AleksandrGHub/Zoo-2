namespace Zoo_2
{
    class LionFactory : Factory
    {
        public override Animal Create()
        {
            return new Lion("Львы", "Р-р-р-р-р!");
        }
    }
}