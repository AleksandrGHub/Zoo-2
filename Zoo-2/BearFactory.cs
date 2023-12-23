namespace Zoo_2
{
    class BearFactory : Factory
    {
        public override Animal Create()
        {
            return new Bear("Медведи", "Ря-я-я-яв!");
        }
    }
}