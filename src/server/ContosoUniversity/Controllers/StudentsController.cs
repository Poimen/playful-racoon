using ContosoUniversity.Models.Students;
using Mediator;
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
        public async ValueTask<ActionResult<CreateStudent.Response>> Create(CreateStudent.Request student, CancellationToken cancellationToken)
        {
            var createdId = await _mediator.Send(student, cancellationToken);
            return new CreateStudent.Response(createdId);
        }
    }
}
