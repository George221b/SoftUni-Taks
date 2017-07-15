using System;

namespace _01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm)
        {
            this.FuelConsumptionPerKm = fuelConsumptionPerKm + 1.6;
        }

        public override string Drive(double distance)
        {
            if (this.FuelQuantity >= distance * this.FuelConsumptionPerKm)
            {
                //can drive
                this.FuelQuantity -= distance * this.FuelConsumptionPerKm;
                return $"Truck travelled {distance} km";
            }
            else
            {
                //can't drive
                return "Truck needs refueling";
            }
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters * 0.95;
        }
    }
}