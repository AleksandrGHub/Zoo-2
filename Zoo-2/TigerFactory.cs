namespace Zoo_2
{
    class TigerFactory : Factory
    {
        public override Animal Create()
        {
            return new Tiger("Тигры", "Р-р-р!");
        }
    }
}