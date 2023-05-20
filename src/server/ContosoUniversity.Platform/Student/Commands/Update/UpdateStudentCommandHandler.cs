using ContosoUniversity.Platform.Api.Students.Commands;
using Fwk.Kernel.Core.Commands;
using Fwk.Kernel.Core.Metadata;
using Fwk.Kernel.Core.Results;

namespace ContosoUniversity.Platform.Student.Commands.Update
{
    public class UpdateStudentCommandHandler : IHandleCommand<UpdateStudentCommand, UpdatedStudentResult>
    {
        public ValueTask<ApplicationResult<UpdatedStudentResult>> Handle(UpdateStudentCommand command, ISystemMetadata metadata)
        {
            return ApplicationResult.Success(new UpdatedStudentResult());
        }
    }
}
