using System.Threading.Tasks;
using ContosoUniversity.Models.Students;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController
    {
        [HttpPost]
        public async Task<ActionResult<Students.CreateStudentResponse>> Create(Students.CreateStudentRequest student)
        {
            return new Students.CreateStudentResponse(1);
        }
    }
}
