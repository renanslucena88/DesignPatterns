namespace AbstractFactory
{
    public class PopularCarFactory : CarFactory
    {
        public override Sound InstallSound()
        {
            return new CDPlayer();
        }

        public override Wheel InstallWheel()
        {
            return new SimpleWheel();
        }
    }
}
