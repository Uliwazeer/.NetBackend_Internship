
namespace EmployeeAPI
{
    //NEW CLASS 1 ADD BY ME
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
    }
    //NEW CLASS 2 ADD BY ME
    public class EmployeeService
    {
        private static List<Employee> _employees = new List<Employee>
    {
        new Employee { Id = 1, Name = "John Doe", Position = "Manager", Salary = 50000 },
        new Employee { Id = 2, Name = "Jane Smith", Position = "Developer", Salary = 60000 }
    };

        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = _employees.FirstOrDefault(e => e.Id == employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Position = employee.Position;
                existingEmployee.Salary = employee.Salary;
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }


    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
