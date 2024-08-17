using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace swagger.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("GetEmployee")]
        public string GetEmployee()
        {
            return "Ali Wazeer From EFG Holding";
        }
    }
}
