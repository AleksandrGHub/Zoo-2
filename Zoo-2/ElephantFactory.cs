namespace Zoo_2
{
    class ElephantFactory : Factory
    {
        public override Animal Create()
        {
            return new Elephant("Слоны", "Фр-р-фр!");
        }
    }
}