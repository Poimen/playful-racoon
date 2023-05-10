using Fwk.Kernel.Core.Commands;
using Fwk.Kernel.Core.Results;

namespace ContosoUniversity.Platform.Api.Students.Commands
{
    public class UpdateStudentCommand : ICommand
    {
        public string FirstName { get; }

        public string LastName { get; }

        public DateTime EnrollmentDate { get; }

        public UpdateStudentCommand(string firstName, string lastName, DateTime enrollmentDate)
        {
            FirstName = firstName;
            LastName = lastName;
            EnrollmentDate = enrollmentDate;
        }
    }

    public class UpdatedStudentResult : ICommandResult
    {
    }
}
