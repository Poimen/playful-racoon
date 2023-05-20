using ContosoUniversity.Platform.Api.Students.Commands;
using Fwk.Kernel.Core.Commands;
using Fwk.Kernel.Core.Metadata;
using Fwk.Kernel.Core.Results;

namespace ContosoUniversity.Platform.Student.Commands.Create
{
    public class CreateStudentCommandHandler : IHandleCommand<CreateStudentCommand>
    {
        public ValueTask<ApplicationResult> Handle(CreateStudentCommand command, ISystemMetadata metadata)
        {
            return ApplicationResult.Success();
        }
    }
}
