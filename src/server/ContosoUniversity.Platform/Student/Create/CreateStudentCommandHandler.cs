using ContosoUniversity.Platform.Api.Students.Commands;
using Fwk.Kernel.Core.Commands;
using Fwk.Kernel.Core.Results;

namespace ContosoUniversity.Platform.Student.Create
{
    public class CreateStudentCommandHandler : IHandleCommand<CreateStudentCommand>
    {
        public ValueTask<ApplicationResult> Handle(CreateStudentCommand command)
        {
            return ApplicationResult.Success();
        }
    }
}
