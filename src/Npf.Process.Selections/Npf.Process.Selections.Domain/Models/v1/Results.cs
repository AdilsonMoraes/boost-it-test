using System.Text.Json.Serialization;

namespace Npf.Process.Selections.Domain.Models.v1
{
    public class Results
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("isMultiple")]
        public bool IsMultiple { get; set; }
    }
}
