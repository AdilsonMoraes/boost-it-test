using Npf.Process.Selections.Domain.Models.v1;
using System.Text.Json.Serialization;

namespace Npf.Process.Selections.Domain.Response.v1
{
    public class Response
    {
        [JsonPropertyName("result")]
        public List<Results> Results { get; set; }
    }
}
