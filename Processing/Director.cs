namespace Processing
{
    public class Director
    {
        public IBuilder builder;

        public Director(int builderType)
        {
            switch(builderType)
            {
                case 1: // Hatchback
                    builder = new HatchbackBuilder();
                    break;
                case 2: // Sedan
                    builder = new SedanBuilder();
                    break;
                case 3: // SUV
                    builder = new SUVBuilder();
                    break;
                case 4: // MUV
                    builder = new MUVBuilder();
                    break;
                case 5: // Convertible
                    builder = new ConvertibleBuilder();
                    break;
                case 6: // Coupe
                    builder = new CoupeBuilder();
                    break;
                case 7: // Pickup
                    builder = new PickupBuilder();
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void ConstructCar()
        {
            builder.BuildCar();
        }

        public CarProduct GetCarProduct()
        {
            return builder.GetResult();
        }
    }
}
