using AutoMapper;
using ContosoUniversity.CommandHandlers.Models;
using ContosoUniversity.Infrastructure.Factories;
using ContosoUniversity.Infrastructure.Providers;
using ContosoUniversity.Models.Students;
using Mediator;

namespace ContosoUniversity.CommandHandlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudent.Request, long>
    {
        private readonly IDbFactory _dbFactory;
        private readonly IMapper _mapper;
        private readonly ITransactionProvider _transactionProvider;

        public CreateStudentHandler(IDbFactory dbFactory, IMapper mapper, ITransactionProvider transactionProvider)
        {
            _dbFactory = dbFactory ?? throw new ArgumentNullException(nameof(dbFactory));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _transactionProvider = transactionProvider;
        }

        public async ValueTask<long> Handle(CreateStudent.Request request, CancellationToken cancellationToken)
        {
            // TODO : business rules

            var model = _mapper.Map<StudentDto>(request);
            var id = await _dbFactory.NewDb().InsertAsync(model);

            return id;
        }
    }
}
