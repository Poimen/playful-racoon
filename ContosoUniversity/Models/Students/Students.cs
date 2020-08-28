using System;

namespace ContosoUniversity.Models.Students
{
    public class Students
    {
        public class CreateStudentRequest
        {
            public string LastName { get; set; }

            public string FirstMidName { get; set; }

            public DateTime EnrollmentDate { get; set; }
        }

        public class CreateStudentResponse
        {
            public int Id { get; }

            public CreateStudentResponse(int id)
            {
                Id = id;
            }
        }
    }
}
