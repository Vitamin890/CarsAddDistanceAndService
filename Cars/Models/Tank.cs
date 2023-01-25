using System;
namespace Cars.Models
{
    public class TankCar : Car
    {
        public TankCar(string mark, int yearOfProductoin, long price, int weight, Color color) :
            base(mark, yearOfProductoin, price, weight, color)
        {

        }

        public override bool IsrReadyToService()
        {
            if (DistanceOnService > 10_000)
            {
                return true;
            }
            return false;
        }

    }
}
