using System.Text.Json.Serialization;

namespace Client.Models
{
    public class TemperatureData
    {
        [JsonPropertyName("value")]
        public double Value { get; set; }

        [JsonPropertyName("sensorId")]
        public string SensorId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("enqueuedTime")]
        public DateTime EnqueuedTime { get; set; }
    }
}
