using System;
using System.Threading.Tasks;
using ContosoUniversity.Controllers;
using ContosoUniversity.Models.Students;
using NUnit.Framework;

namespace ContosoUniversity.Test.Controllers
{
    [TestFixture]
    public class StudentControllerTests
    {
        [Test]
        public async Task GivenStudentDoesNotExist_ShouldReturnId()
        {
            // Arrange
            var student = new CreateStudent.Request
            {
                FirstMidName = "Joe",
                LastName = "Soap",
                EnrollmentDate = new DateTime()
            };
            var controller = CreateController();
            // Act
            var result = await controller.Create(student);
            // Assert
            Assert.That(result.Value.Id, Is.EqualTo(1));
        }

        private static StudentsController CreateController()
        {
            return new StudentsController();
        }
    }
}
