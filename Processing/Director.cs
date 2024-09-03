/******************************************************************************
 * Filename    = Director.cs
 *
 * Author      = Pranav Guruprasad Rao
 *
 * Product     = BuilderPatternDemo
 * 
 * Project     = Processing
 *
 * Description = Director for Car Product
 *****************************************************************************/

namespace Processing
{
    /// <summary>
    /// Directs the construction of Cars according to user choice
    /// </summary>
    public class Director
    {
        public IBuilder Builder;

        /// <summary>
        /// Assigns an IBuilder object based on the user choice
        /// </summary>
        /// <param name="builderType">Car Type specified by user</param>
        public Director(int builderType)
        {
            Console.WriteLine(builderType);
            switch(builderType)
            {
                case 1: /// <summary>Hatchback</summary>
                    Builder = new HatchbackBuilder();
                    break;
                case 2: /// <summary>Sedan</summary>
                    Builder = new SedanBuilder();
                    break;
                case 3: /// <summary>SUV</summary>
                    Builder = new SUVBuilder();
                    break;
                case 4: /// <summary>MUV</summary>
                    Builder = new MUVBuilder();
                    break;
                case 5: /// <summary>Convertible</summary>
                    Builder = new ConvertibleBuilder();
                    break;
                case 6: /// <summary>Coupe</summary>
                    Builder = new CoupeBuilder();
                    break;
                case 7: /// <summary>Pickup</summary>
                    Builder = new PickupBuilder();
                    break;
                default:
                    throw new ArgumentException("Incorrect input provided.");
            }
        }

        /// <summary>
        /// Construct the car using the builder
        /// </summary>
        public void ConstructCar()
        {
            Builder.BuildCar();
        }

        /// <summary>
        /// Return the constructed car product
        /// </summary>
        public CarProduct GetCarProduct()
        {
            return Builder.GetResult();
        }
    }
}
