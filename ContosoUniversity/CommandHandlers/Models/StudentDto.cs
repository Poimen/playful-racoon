using System;
using AutoMapper;
using ContosoUniversity.Infrastructure;
using ContosoUniversity.Models.Students;
using Dapper.Contrib.Extensions;

namespace ContosoUniversity.CommandHandlers.Models
{
    [Table ("student")]
    public class StudentDto : IDatabaseModel
    {
        public int Id { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }

    public class StudentMapperProfile : Profile
    {
        public StudentMapperProfile()
        {
            CreateMap<CreateStudent.Request, StudentDto>()
                .ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
