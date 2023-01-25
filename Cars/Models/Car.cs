using System;
namespace Cars.Models
{
    public abstract class Car : IServicable

//----------------------- Поля ----------------------------
    {


        public string Mark { get; set; }
        public int YearOfProductoin { get; set; }
        public long Price { get; set; }
        public int Weight { get; set; }
        public Color Color { get; set; }
        public int Distance { get; set; }
        public int DistanceOnService { get; set; }

//------------------- Конструктор -------------------------

        public Car(string mark, int yearOfProductoin, long price, int weight, Color color)
        {
            Mark = mark;
            YearOfProductoin = yearOfProductoin;
            Price = price;
            Weight = weight;
            Color = color;
        }



//------------------- Бизнес методы -----------------------

        public void AddDistance (int newDistance)
        {
            Distance += newDistance;
            DistanceOnService += newDistance;
        }


        public void AddDistance(double newDistance)
        {
            Distance += (int) newDistance;
            DistanceOnService += (int) newDistance;
        }


//----------------- Служебные методы ----------------------

        public override string ToString()
        {
            return " Car Mark: " + Mark + " YearOfProduction: " + YearOfProductoin + " Price: " + Price + " Weight: " + Weight + " Distance: " + Distance + " Color: " + Color + "";
        }



        public override bool Equals(object obj)
        {
            return obj is Car car &&
                   Mark == car.Mark &&
                   YearOfProductoin == car.YearOfProductoin &&
                   Price == car.Price &&
                   Weight == car.Weight &&
                   Color == car.Color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Mark, YearOfProductoin, Price, Weight, Color);
        }

        public abstract bool IsrReadyToService();

        public static bool operator ==(Car left, Car right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Car left, Car right)
        {
            return !Equals(left, right);
        }

    }
}
