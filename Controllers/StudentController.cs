using EntityFramework.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentDBContext dBContext;
        
        public StudentController(StudentDBContext dBContext) {
            this.dBContext = dBContext;        
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dBContext.students);
        }
    }
}
