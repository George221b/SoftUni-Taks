using System;

namespace _01.Vehicles.Models
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm)
        {
            this.FuelConsumptionPerKm = fuelConsumptionPerKm + 0.9;
        }

        public override string Drive(double distance)
        {
            if (this.FuelQuantity >= distance * this.FuelConsumptionPerKm)
            {
                this.FuelQuantity -= distance * this.FuelConsumptionPerKm;
                return $"Car travelled {distance} km";
            }
            else
            {
                return "Car needs refueling";
            }
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }
    }
}
