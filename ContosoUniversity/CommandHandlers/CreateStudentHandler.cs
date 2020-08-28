using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ContosoUniversity.CommandHandlers.Models;
using ContosoUniversity.Infrastructure;
using ContosoUniversity.Models.Students;
using MediatR;

namespace ContosoUniversity.CommandHandlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudent.Request, int>
    {
        private readonly IDbFactory _dbFactory;
        private readonly IMapper _mapper;

        public CreateStudentHandler(IDbFactory dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory ?? throw new ArgumentNullException(nameof(dbFactory));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public Task<int> Handle(CreateStudent.Request request, CancellationToken cancellationToken)
        {
            // TODO : business rules

            var model = _mapper.Map<StudentDto>(request);
            _dbFactory.NewDb().Insert(model);

            return Task.FromResult(1);
        }
    }
}
