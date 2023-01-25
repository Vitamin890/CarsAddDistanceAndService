using System;
namespace Cars.Models
{
    public interface IServicable
    {
        public  bool IsrReadyToService();
        public void AddDistance(double newDistance);
        public void AddDistance(int newDistance);
    }
}
