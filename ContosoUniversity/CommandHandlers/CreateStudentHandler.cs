using System.Threading;
using System.Threading.Tasks;
using ContosoUniversity.Models.Students;
using MediatR;

namespace ContosoUniversity.CommandHandlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudent.Request, int>
    {
        public Task<int> Handle(CreateStudent.Request request, CancellationToken cancellationToken)
        {
            return Task.FromResult(1);
        }
    }
}
