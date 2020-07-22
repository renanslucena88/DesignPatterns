namespace AbstractFactory
{
    public class LuxuryCarFactory : CarFactory
    {
        public override Sound InstallSound()
        {
            return new BluetoothPlayer();
        }

        public override Wheel InstallWheel()
        {
            return new AlloyWheel();
        }
    }
}
