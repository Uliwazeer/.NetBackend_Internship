using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeesController()
        {
            _employeeService = new EmployeeService();
        }

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return _employeeService.GetAllEmployees();
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Employee employee)
        {
            _employeeService.AddEmployee(employee);
            return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Employee employee)
        {
            var existingEmployee = _employeeService.GetEmployeeById(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }
            _employeeService.UpdateEmployee(employee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            _employeeService.DeleteEmployee(id);
            return NoContent();
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

