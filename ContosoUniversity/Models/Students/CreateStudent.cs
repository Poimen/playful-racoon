using System;
using FluentValidation;
using MediatR;

namespace ContosoUniversity.Models.Students
{
    public class CreateStudent
    {
        public class Request : IRequest<long>
        {
            public string LastName { get; set; }

            public string FirstMidName { get; set; }

            public DateTime EnrollmentDate { get; set; }
        }

        public class Validator : AbstractValidator<Request>
        {
            public Validator()
            {
                RuleFor(m => m.LastName).NotNull().Length(1, 50);
                RuleFor(m => m.FirstMidName).NotNull().Length(1, 50);
                RuleFor(m => m.EnrollmentDate).NotNull();
            }
        }

        public class Response
        {
            public long Id { get; }

            public Response(long id)
            {
                Id = id;
            }
        }
    }
}
