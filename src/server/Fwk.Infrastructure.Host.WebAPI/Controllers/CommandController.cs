using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fwk.Infrastructure.Host.WebAPI.Controllers
{
    public class Namey
    {
        [JsonPropertyName("_name")]
        public string Name { get; set; }
    }
    public class Namey2
    {
        [JsonPropertyName("bob")]
        public string Bob { get; }

        public Namey2(string bob)
        {
            Bob = bob;
        }
    }

    public static class TransportConstants
    {
        public const string TypeMarker = "_type";
    }

    [ApiController]
    [Route("api/[controller]")]
    public class PerformCommandHandlerController
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PerformCommandHandlerController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        [HttpPost]
        public IActionResult Process(JsonElement body)
        {
            if (body.TryGetProperty(TransportConstants.TypeMarker, out var jsonTypeMarker))
            {
                var typeName = jsonTypeMarker.GetString();

                var namey2 = body.Deserialize<Namey2>();
            }

            var problemDetails = new ProblemDetails
            {
                Title = "Resource not found",
                Detail = "The requested resource was not found.",
                Status = 404,
                Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4",
                Instance = GetRequestUrl()
            };

            return new ObjectResult(problemDetails)
            {
                StatusCode = problemDetails.Status
            };
        }

        private string GetRequestUrl()
        {
            var request = _httpContextAccessor.HttpContext?.Request;
            return request == null
                ? ""
                : $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString}";
        }
    }
}
