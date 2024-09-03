/******************************************************************************
 * Filename    = Program.cs
 *
 * Author      = Pranav Guruprasad Rao
 *
 * Product     = BuilderPatternDemo
 * 
 * Project     = Execution
 *
 * Description = Console Application
 *****************************************************************************/

using Processing;

namespace Execution
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Car Builder. Please specify your choice of car:");
            List<string> carTypes = new List<string>{ "Hatchback", "Sedan", "SUV", "MUV", "Convertible", "Coupe", "Pickup" };

            for (int i = 0; i < carTypes.Count; i++)
            {
                Console.WriteLine($"{i+1}. {carTypes[i]}");
            }

            try
            {
                int userChoice = Convert.ToInt32(Console.ReadLine());  // natural number between 1-7, cannot input floating points, cannot input string
                if (userChoice < 1 || userChoice > 7)
                {
                    throw new Exception("Please enter your choice between the range: 1 - 7");
                }
                
                Director director = new Director(userChoice);
                director.ConstructCar();
                CarProduct carProduct = director.GetCarProduct();
                string carInfo = carProduct.DisplayInfo();

                Console.WriteLine(carInfo);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
