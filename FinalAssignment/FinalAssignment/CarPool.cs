using System;

namespace FinalAssignment
{
    public class CarPool
    {
        private static List<CarPool> carPoolList; 

        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int EndOfLifeMileage { get; set; }
        public int MaintenanceInterval { get; set; }
        public int CurrentMileage { get; set; }
        public string? RegistrationPlate { get; set; }

        public static void InitializeCarPoolList()
        {
            carPoolList = new List<CarPool>();
        }

        public static List<CarPool> GetCarPoolList()
        {
            return carPoolList;
        }

        public static void SetCarPoolList(List<CarPool> newList)
        {
            carPoolList = newList;
        }

        public void AddToCarPool()
        {
            if (carPoolList.Any(car => car.RegistrationPlate == RegistrationPlate))
            {
                throw new Exception("A car with the same registration plate already exists in the car pool.");
            }

            carPoolList.Add(this);
        }

        public void RemoveFromCarPool()
        {
            carPoolList.Remove(this);
        }

        public static CarPool GetCarFromCarPool(int index)
        {
            return carPoolList[index];
        }

        public string GetCarDisplayName()
        {
            int carIndex = carPoolList.IndexOf(this) + 1;
            return "Car " + carIndex;
        }

        public string GetCarInfo()
        {
            return $"Brand: {Brand}\nModel: {Model}\nEnd of Life Mileage: {EndOfLifeMileage}\nMaintenance Interval: {MaintenanceInterval}\nCurrent Mileage: {CurrentMileage}\nRegistration Plate: {RegistrationPlate}";
        }


    }
}
