using ContosoUniversity.Platform.Api.Students.Commands;
using ContosoUniversity.Platform.Api.Students.Commands.Results;
using Fwk.Kernel.Core.Commands;
using Fwk.Kernel.Core.Results;

namespace ContosoUniversity.Platform.Student.Update
{
    public class UpdateStudentCommandHandler : IHandleCommand<UpdateStudentCommand, UpdatedStudentResult>
    {
        public ValueTask<ApplicationResult<UpdatedStudentResult>> Handle(UpdateStudentCommand command)
        {
            return ApplicationResult<UpdatedStudentResult>.Success(new UpdatedStudentResult());
        }
    }
}
