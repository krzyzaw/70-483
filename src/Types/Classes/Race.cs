using System.Collections.Generic;

namespace Types.Classes
{
    public class Race
    {
        public void Begin()
        {
            SportCar sportCar = new SportCar();
            Truck truck = new Truck();

            List<Car> cars = new List<Car>() { sportCar, truck };

            foreach (var car in cars)
            {
                car.Start();
                car.Accelerate();
            }
        }
    }
}