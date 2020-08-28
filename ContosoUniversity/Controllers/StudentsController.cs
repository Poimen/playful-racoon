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
        public async Task<ActionResult<CreateStudent.Response>> Create(CreateStudent.Request student)
        {
            return new CreateStudent.Response(1);
        }
    }
}
