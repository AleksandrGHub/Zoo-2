namespace Zoo_2
{
    class HorseFactory : Factory
    {
        public override Animal Create()
        {
            return new Horse("Лошади", "И-и-и-го-го!");
        }
    }
}