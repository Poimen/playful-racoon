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

    [ApiController]
    [Route("api/[controller]")]
    public class CommandController
    {
        [HttpPost]
        public ValueTask<int> Process(JsonElement body)
        {
            var obj = body.GetProperty("_name");

            var n = body.Deserialize(typeof(Namey2));

            return new ValueTask<int>(1);
        }
    }
}
