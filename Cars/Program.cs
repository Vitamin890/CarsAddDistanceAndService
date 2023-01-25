using Cars.Models;
using System;
using System.Collections.Generic;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {

            IServicable renaultBus = new Bus("Traffic", 2000, 9700, 2600, Color.White);

            IServicable renaultPassendger = new PassendgerCar("Traffic", 2000, 12000, 2600, Color.Blue);

            IServicable renaultTank = new TankCar("Traffic", 2000, 9700, 2600, Color.Black);

            renaultPassendger.AddDistance(1000);
            Console.WriteLine("Is time to servis Bus?: " + renaultPassendger.IsrReadyToService());

            renaultBus.AddDistance(50002);
            Console.WriteLine("Is time to servis Passendger?: " + renaultBus.IsrReadyToService());

            renaultTank.AddDistance(50002);
            Console.WriteLine("Is time to servis Tank?: " + renaultTank.IsrReadyToService());
            
            Console.WriteLine(renaultBus);
            Console.WriteLine(renaultPassendger);
            Console.WriteLine(renaultTank);

            Console.WriteLine(renaultBus == renaultPassendger);
            Console.WriteLine(renaultPassendger == renaultBus);

            List<IServicable> collection = new List<IServicable>();
            collection.Add(renaultBus);
            collection.Add(renaultPassendger);
            collection.Add(renaultTank);

            Console.WriteLine(collection);

            static void WriteLineItems(List<IServicable>[] lists)
            {
                foreach (var list in lists)
                {
                    foreach (var item in list)
                        Console.WriteLine(item);
                }
            }
        }
    }
}
