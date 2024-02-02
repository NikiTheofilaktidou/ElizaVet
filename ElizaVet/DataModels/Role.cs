using Newtonsoft.Json;

namespace ElizaVet.DataModels
{
    public class Role
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
