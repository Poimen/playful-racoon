using System;
using System.Threading.Tasks;
using ContosoUniversity.Models.Students;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        public async Task<ActionResult<CreateStudent.Response>> Create(CreateStudent.Request student)
        {
            var createdId = await _mediator.Send(student);
            return new CreateStudent.Response(createdId);
        }
    }
}
