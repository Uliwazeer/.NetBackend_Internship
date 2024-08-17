using Crud.Models;

namespace Crud.Caching
{
    public static class EmployeeStorage
    {
        private static readonly List<Employee> _employees = new List<Employee>();

        public static List<Employee> GetAllEmployees() => _employees;

        public static Employee GetEmployeeById(int id) => _employees.FirstOrDefault(e => e.Id == id);

        public static void AddEmployee(Employee employee) => _employees.Add(employee);

        public static void UpdateEmployee(Employee updatedEmployee)
        {
            var index = _employees.FindIndex(e => e.Id == updatedEmployee.Id);
            if (index != -1)
            {
                _employees[index] = updatedEmployee;
            }
        }

        public static void DeleteEmployee(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }

}
