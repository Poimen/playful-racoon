using ContosoUniversity.Platform.Api.Students.Queries;
using Fwk.Kernel.Core.Metadata;
using Fwk.Kernel.Core.Queries;
using Fwk.Kernel.Core.Results;

namespace ContosoUniversity.Platform.Student.Queries
{
    public class GetAllStudentsQueryHandler : IHandleQuery<GetAllStudentsQuery, GetAllStudentsQueryResult>
    {
        public ValueTask<ApplicationResult<GetAllStudentsQueryResult>> Handle(GetAllStudentsQuery query, ISystemMetadata metadata)
        {
            return ApplicationResult.Success(new GetAllStudentsQueryResult());
        }
    }
}
