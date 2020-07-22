namespace AbstractFactory
{
    public class ExecAbstractFactory
    {
        public static Car ProdCar(string type)
        {
            CarFactory cf;
            switch (type)
            {
                case "Luxury":
                    cf = new LuxuryCarFactory();
                    break;
                case "Popular":
                    cf = new PopularCarFactory();
                    break;
                default:
                    return null;
            }

            Car car = new Car();
            car.Wheel = cf.InstallWheel();
            car.Sound = cf.InstallSound();

            return car;
        }
    }
}
