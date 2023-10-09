using System;

namespace FinalAssignment
{
    public class Employees
    {
        private static List<Employees> EmployeeList; // Static variable for the car pool list

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        public static void InitializeEmployeesList()
        {
            EmployeeList = new List<Employees>();
        }

        public static List<Employees> GetEmployeesList()
        {
            return EmployeeList;
        }

        public static void SetEmployeesList(List<Employees> newList)
        {
            EmployeeList = newList;
        }

        public void AddToEmployees()
        {
            EmployeeList.Add(this);
        }

        public void RemoveFromEmployees()
        {
            EmployeeList.Remove(this);
        }

        public static Employees GetEmployeeFromEmployees(int index)
        {
            return EmployeeList[index];
        }

        public string GetEmployeeDisplayName()
        {
            int empIndex = EmployeeList.IndexOf(this) + 1;
            return "Employee " + empIndex;
        }

        public string GetEmployeeInfo()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nAge: {Age}";
        }
    }
}
