using Newtonsoft.Json;

namespace ElizaVet.DataModels
{
    public class User
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "firstname")]
        public string? Firstname { get; set; }

        [JsonProperty(PropertyName = "lastname")]
        public string? Lastname { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string? Address { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }

        [JsonProperty(PropertyName = "imageUrl")]
        public string? ImageUrl { get; set; }

        [JsonProperty(PropertyName = "patientId")]
        public long? PatientId { get; set; }

        [JsonProperty(PropertyName = "roleId")]
        public int? RoleId { get; set; }
    }
}
