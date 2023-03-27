using ContosoUniversity.Platform.Api.Students.Commands;
using Fwk.Kernel.Core.Commands;

namespace ContosoUniversity.Platform.Student
{
    public class CreateStudent : IHandleCommand<CreateStudentCommand>
    {
        public void Handle(CreateStudentCommand command)
        {
            throw new NotImplementedException();
        }

        ICommandResult IHandleCommand<CreateStudentCommand>.Handle(CreateStudentCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
