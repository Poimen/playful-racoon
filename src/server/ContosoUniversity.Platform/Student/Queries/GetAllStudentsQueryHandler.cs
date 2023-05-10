using ContosoUniversity.Platform.Api.Students.Queries;
using Fwk.Kernel.Core.Queries;
using Fwk.Kernel.Core.Results;

namespace ContosoUniversity.Platform.Student.Queries
{
    public class GetAllStudentsQueryHandler : IHandleQuery<GetAllStudentsQuery, GetAllStudentsQueryResult>
    {
        public ValueTask<ApplicationResult<GetAllStudentsQueryResult>> Handle(GetAllStudentsQuery query)
        {
            return ApplicationResult.Success(new GetAllStudentsQueryResult());
        }
    }
}
