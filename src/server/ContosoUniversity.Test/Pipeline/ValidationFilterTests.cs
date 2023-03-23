using System.Collections.Generic;
using ContosoUniversity.Controllers;
using ContosoUniversity.Pipeline;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using NUnit.Framework;

namespace ContosoUniversity.Test.Pipeline
{
    [TestFixture]
    public class ValidationFilterTests
    {
        private ActionContext _actionContext;

        [SetUp]
        public void SetUp()
        {
            _actionContext = new ActionContext()
            {
                HttpContext = new DefaultHttpContext(),
                RouteData = new RouteData(),
                ActionDescriptor = new ActionDescriptor()
            };
        }

        [Test]
        public void GivenUnsuccessfulModelValidation_FilterShouldSetResultToBadRequest()
        {
            // Arrange
            var context = new ActionExecutedContext(_actionContext, new List<IFilterMetadata>(), null);
            context.ModelState.AddModelError("error", "some error");
            var filter = CreateFilter();
            // Act
            filter.OnActionExecuted(context);
            // Assert
            Assert.That(context.Result, Is.Not.Null);
            var result = (BadRequestObjectResult) context.Result;
            Assert.That(result.StatusCode, Is.EqualTo(400));
        }

        [Test]
        public void GivenSuccessfulModelValidation_FilterShouldNotSetResult()
        {
            // Arrange
            var context = new ActionExecutedContext(_actionContext, new List<IFilterMetadata>(), null);
            var filter = CreateFilter();
            // Act
            filter.OnActionExecuted(context);
            // Assert
            Assert.That(context.Result, Is.Null);
        }

        private static ValidationFilter CreateFilter()
        {
            return new ValidationFilter();
        }
    }
}
