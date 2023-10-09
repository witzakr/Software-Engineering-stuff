using System.Collections.Generic;

namespace FinalAssignment
{
    public class Trip
    {
        private static List<Trip> tripList;
        public CarPool Car { get; set; }
        public Employees Employee { get; set; }
        public int Length { get; set; }

        public static void InitializeTripList()
        {
            tripList = new List<Trip>();
        }

        public static List<Trip> GetTripList()
        {
            return tripList;
        }

        public static void SetTripList(List<Trip> newList)
        {
            tripList = newList;
        }

        public void AddToTripList()
        {
            tripList.Add(this);
        }

        public void RemoveFromTripList()
        {
            tripList.Remove(this);
        }

        public static Trip GetTripFromTripList(int index)
        {
            return tripList[index];
        }

        public string GetTripDisplayName()
        {
            int tripIndex = tripList.IndexOf(this) + 1;
            return "Trip " + tripIndex;
        }

        public string GetTripInfo()
        {
            return $"Car Info:\n{Car.GetCarInfo()}\n\nEmployee Info:\n{Employee.GetEmployeeInfo()}";
        }
    }
}
