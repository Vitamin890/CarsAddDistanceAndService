﻿using System;
namespace Cars.Models
{
    public class Bus : Car
    {
        public Bus(string mark, int yearOfProductoin, long price, int weight, Color color):
            base(mark, yearOfProductoin, price, weight, color)
        {
        }

        public override bool IsrReadyToService()
        {
            if (DistanceOnService > 50000)
            {
                return true;
            }
            return false;
        }

    }
}
