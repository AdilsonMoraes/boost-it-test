using Npf.Process.Selections.Domain.Models.v1;
using System.Text.Json.Serialization;

namespace Npf.Process.Selections.Domain.Request.v1
{
    public class Request
    {
        [JsonPropertyName("numbers")]
        public int[] Number { get; set; }
    }
}
