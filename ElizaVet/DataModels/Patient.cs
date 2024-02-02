using Newtonsoft.Json;

namespace ElizaVet.DataModels
{
    public class Patient
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "patientName")]
        public string? PatientName { get; set; }

        [JsonProperty(PropertyName = "species")]
        public string? Species { get; set; }

        [JsonProperty(PropertyName = "age")]
        public int Age { get; set; }

        [JsonProperty(PropertyName = "breed")]
        public string? Breed { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string? Gender { get; set; }

        [JsonProperty(PropertyName = "history")]
        public string? History { get; set; }

        [JsonProperty(PropertyName = "healthcare")]
        public string? Healthcare { get; set; }

        [JsonProperty(PropertyName = "purchaseHistory")]
        public string? PurchaseHistory { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public long? UserId { get; set; }
    }
}
